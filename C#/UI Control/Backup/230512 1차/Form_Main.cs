using OpenCvSharp;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TM_Parameter;

namespace TM_UI
{
    public partial class Form_Main : Form
    {
        // 변수 선언
        public static System.Drawing.Point resultPoint;
        public static OpenCvSharp.Point maxPoint_Public;
        public static double similarity_Public;
        public static (int, double, OpenCvSharp.Point)[] tuple_Multiple_arr_Public = new (int, double, OpenCvSharp.Point)[Form_Parameter.multiple_Count];
        private bool isOriginalImageOpen = false;
        private bool isTemplateImageOpen = false;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void ui_ImageLoadBtn_Click(object sender, EventArgs e)
        {
            string Image_File = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File|*jpg;*.jpeg;*.bmp;*.png;*.gif;*.tif;";
            DialogResult result = dialog.ShowDialog();

            // 이미지 파일 불러오기
            if (result == DialogResult.OK)
            {
                Image_File = dialog.FileName;
                string filename = Path.GetFileName(Image_File);
                ui_label_Filename.Text = $"File name: {filename}";

                //다른 탭 초기화
                ui_imageBox_Gray.Image = null;
                ui_imageBox_Sim.Image = null;
                ui_imageBox_Result.Image = null;

                //원본 이미지로 이동
                UI_tabControl.SelectedTab = UI_tabPage_Og;

                isOriginalImageOpen = true;

                if (isOriginalImageOpen && isTemplateImageOpen)
                {
                    ui_MatchingBtn.Enabled = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            //이미지 파일 표시
            ui_imageBox_Og.Image = Bitmap.FromFile(Image_File);
        }

        private void ui_TempLoadBtn_Click(object sender, EventArgs e)
        {
            string Image_File = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File|*jpg;*.jpeg;*.bmp;*.png;*.gif;*.tif;";
            DialogResult result = dialog.ShowDialog();

            // 템플릿 이미지 파일 불러오기
            if (result == DialogResult.OK)
            {
                Image_File = dialog.FileName;
                isTemplateImageOpen = true;
                if (isOriginalImageOpen && isTemplateImageOpen)
                {
                    ui_MatchingBtn.Enabled = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            // 템플릿 이미지 표시
            ui_imageBox_Temp.Image = Bitmap.FromFile(Image_File);
        }

        private void ui_MatchingBtn_Click(object sender, EventArgs e)
        {
            Mat gray_result = new Mat();
            Mat tm_result = new Mat();
            Mat result = new Mat();
            int rank = 1;
            double similarity = 0;
            OpenCvSharp.Point maxPoint = new OpenCvSharp.Point();

            if (ui_imageBox_Og.Image != null && ui_imageBox_Temp.Image != null)
            {
                // PictureBox의 현재 이미지 불러오기 및 Mat 변환
                Bitmap Og_Image_bmp = new Bitmap(ui_imageBox_Og.Image);
                Bitmap Template_Image_bmp = new Bitmap(ui_imageBox_Temp.Image);
                Mat Og_Image_Mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(Og_Image_bmp);
                Mat Template_Image_Mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(Template_Image_bmp);

                // 템플릿 매칭 실행
                var Temp_Matching = new TM_Matching.Matching();
                if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
                {
                    Temp_Matching.Template_Single(Og_Image_Mat, Template_Image_Mat, out gray_result, out tm_result, out result, out rank, out similarity, out maxPoint);
                    maxPoint_Public = maxPoint;
                    similarity_Public = similarity;

                    // listView에 Data 입력
                    ui_listView.Items.Clear();
                    if (similarity >= Form_Parameter.single_Thr)
                    {
                        this.ui_listViewAdd(rank, similarity, maxPoint);
                    }
                }
                else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
                {
                    Temp_Matching.Template_Multiple(Og_Image_Mat, Template_Image_Mat, out gray_result, out tm_result, out result, out (int, double, OpenCvSharp.Point)[] tuple_Multiple_arr);
                    tuple_Multiple_arr_Public = tuple_Multiple_arr;

                    // listView에 Data 입력
                    ui_listView.Items.Clear();
                    for (int i = 1; i <= Form_Parameter.multiple_Count; i++)
                    {
                        this.ui_listViewAdd(tuple_Multiple_arr[i - 1].Item1, tuple_Multiple_arr[i - 1].Item2, tuple_Multiple_arr[i - 1].Item3);
                    }
                }

                // 각 탭의 이미지 Bitmap 변환 및 출력
                if (result != null)
                {
                    Bitmap gray_bmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gray_result);
                    ui_imageBox_Gray.Image = gray_bmp;
                    Bitmap sm_bmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(tm_result);
                    ui_imageBox_Sim.Image = sm_bmp;
                    Bitmap result_bmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(result);
                    ui_imageBox_Result.Image = result_bmp;

                    // 매칭 결과 탭으로 이동
                    UI_tabControl.SelectedTab = UI_tabPage_Result;
                }
                else
                {
                    ui_imageBox_Gray.Image = null;
                    ui_imageBox_Sim.Image = null;
                    ui_imageBox_Result.Image = null;

                    UI_tabControl.SelectedTab = UI_tabPage_Og;
                }
            }

            else
            {
                // 오류 메시지
                MessageBox.Show("이미지 또는 템플릿을 불러와야 합니다.", "Error");
            }
        }

        private void ui_ParameterBtn_Click(object sender, EventArgs e)
        {
            Form_Parameter parameter_dlg = new Form_Parameter();
            parameter_dlg.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //타이머 작동
            timer_Sec.Interval = 500;
            timer_Sec.Start();

            // listView 사이즈 자동 조정
            ui_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ui_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ui_MatchingBtn.Enabled = false;
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            ui_label_Time.Text = DateTime.Now.ToString("F");
        }
        private void ui_listViewAdd(int rank, double similarity, OpenCvSharp.Point maxPoint)
        {
            ui_listView.BeginUpdate();

            ListViewItem ui_listViewItem = new ListViewItem(rank.ToString());
            ui_listViewItem.SubItems.Add($"{Math.Round(similarity, 3)}");
            ui_listViewItem.SubItems.Add($"({maxPoint.X}, {maxPoint.Y})");
            ui_listView.Items.Add(ui_listViewItem);

            ui_listView.EndUpdate();
        }

        private void ui_listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ui_listView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void Form_Main_SizeChanged(object sender, EventArgs e)
        {
            // listView 사이즈 자동 조정
            ui_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ui_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ui_imageBox_Og_ImageChanged(object sender, EventArgs e)
        {
            ui_imageBox_Og.ZoomToFit();
        }

        private void ui_imageBox_Gray_ImageChanged(object sender, EventArgs e)
        {
            ui_imageBox_Gray.ZoomToFit();
        }

        private void ui_imageBox_Sim_ImageChanged(object sender, EventArgs e)
        {
            ui_imageBox_Sim.ZoomToFit();
        }

        private void ui_imageBox_Result_ImageChanged(object sender, EventArgs e)
        {
            ui_imageBox_Result.ZoomToFit();
        }

        private void ui_imageBox_Result_MouseHover(object sender, EventArgs e)
        {
            ui_toolTip_Result.SetToolTip(ui_imageBox_Result, $"유사도: {Math.Round(similarity_Public, 3)}");
        }

        private string FormatPoint(System.Drawing.Point point)
        {
            return string.Format("좌표 (X, Y): ({0}, {1})", point.X, point.Y);
        }
        private void UpdateCursorPosition_Og(System.Drawing.Point location)
        {
            if (ui_imageBox_Og.IsPointInImage(location))
            {
                System.Drawing.Point point;
                point = ui_imageBox_Og.PointToImage(location);
                ui_label_Point.Text = this.FormatPoint(point);
            }
            else
            {
                ui_label_Point.Text = "좌표 (X, Y): ()";
            }
        }
        private void UpdateCursorPosition_Gray(System.Drawing.Point location)
        {
            if (ui_imageBox_Gray.IsPointInImage(location))
            {
                System.Drawing.Point point;
                point = ui_imageBox_Gray.PointToImage(location);
                ui_label_Point.Text = this.FormatPoint(point);
            }
            else
            {
                ui_label_Point.Text = "좌표 (X, Y): ()";
            }
        }
        private void UpdateCursorPosition_Sim(System.Drawing.Point location)
        {
            if (ui_imageBox_Sim.IsPointInImage(location))
            {
                System.Drawing.Point point;
                point = ui_imageBox_Sim.PointToImage(location);
                ui_label_Point.Text = this.FormatPoint(point);
            }
            else
            {
                ui_label_Point.Text = "좌표 (X, Y): ()";
            }
        }
        private void UpdateCursorPosition_Result(System.Drawing.Point location)
        {
            if (ui_imageBox_Result.IsPointInImage(location))
            {
                System.Drawing.Point point;
                point = ui_imageBox_Result.PointToImage(location);
                ui_label_Point.Text = this.FormatPoint(point);
            }
            else
            {
                ui_label_Point.Text = "좌표 (X, Y): ()";
            }
        }
        private System.Drawing.Point ReturnPoint(System.Drawing.Point location)
        {
            System.Drawing.Point point = new System.Drawing.Point();
            if (ui_imageBox_Result.IsPointInImage(location))
            {
                point = ui_imageBox_Result.PointToImage(location);
            }
            return point;
        }

        private void ui_imageBox_Og_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateCursorPosition_Og(e.Location);
        }

        private void ui_imageBox_Gray_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateCursorPosition_Gray(e.Location);
        }

        private void ui_imageBox_Sim_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateCursorPosition_Sim(e.Location);
        }

        private void ui_imageBox_Result_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateCursorPosition_Result(e.Location);
            resultPoint = this.ReturnPoint(e.Location);
            
            if (ui_imageBox_Result.Image == null)
            {
                return;
            }

            Bitmap Template_Image_bmp = new Bitmap(ui_imageBox_Temp.Image);
            Mat Template_Image_Mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(Template_Image_bmp);

            if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
            {
                Rectangle rectangle = new Rectangle(maxPoint_Public.X, maxPoint_Public.Y, Template_Image_Mat.Width, Template_Image_Mat.Height);
                if (rectangle.Contains(resultPoint.X, resultPoint.Y))
                {
                    ui_toolTip_Result.Active = true;
                }
                else
                {
                    ui_toolTip_Result.Active = false;
                }
            }
            else
            {
                Rectangle resultRectangle;
                //tuple_Multiple_arr_Public = new (int, double, OpenCvSharp.Point)[Form_Parameter.multiple_Count];
                for (int rectIndex = 0; rectIndex < Form_Parameter.multiple_Count; ++rectIndex)
                {
                    resultRectangle = new Rectangle(tuple_Multiple_arr_Public[rectIndex].Item3.X, tuple_Multiple_arr_Public[rectIndex].Item3.Y, Template_Image_Mat.Width, Template_Image_Mat.Height);
                    if (resultRectangle.Contains(resultPoint.X, resultPoint.Y))
                    {
                        ui_toolTip_Result.SetToolTip(ui_imageBox_Result, $"유사도: {Math.Round(tuple_Multiple_arr_Public[rectIndex].Item2, 3)}");
                        break;
                    }
                }
            }
        }
    }
}
