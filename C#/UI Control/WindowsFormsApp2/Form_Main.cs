using OpenCvSharp;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TM_Matching;
using TM_Parameter;
using Excel = Microsoft.Office.Interop.Excel;

namespace TM_Main
{
    public partial class Form_Main : Form
    {
        #region 변수 선언
        public System.Drawing.Point resultPoint;
        public OpenCvSharp.Point maxPoint_Public;
        public double similarity_Main;
        public double single_Thr_Main = 0;
        public int multiple_Count_Main = 1;
        private bool isOriginalImageOpen = false;
        private bool isTemplateImageOpen = false;
        public (int, double, OpenCvSharp.Point)[] tuple_Multiple_arr_Main;
        public Matching matching_Main = new Matching();
        public double single_Thr_Matching = 0;
        public int multiple_Count_Matching = 1;
        public Rectangle rectangle_Result;
        public Rectangle[] rectangles_Result;
        #endregion

        public Form_Main()
        {
            InitializeComponent();
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

            if (ui_listView.Items.Count == 0)
            {
                ui_button_ExcelSave.Enabled = false;
            }
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            ui_label_Time.Text = DateTime.Now.ToString("F");
        }

        #region button

        private void ui_ImageLoadBtn_Click(object sender, EventArgs e)
        {
            string Image_File = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Image Load";
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
            ui_imageBox_Og.Image = Image.FromFile(Image_File);
        }

        private void ui_TempLoadBtn_Click(object sender, EventArgs e)
        {
            string Image_File = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Template Load";
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
            ui_imageBox_Temp.Image = Image.FromFile(Image_File);
        }

        private void ui_MatchingBtn_Click(object sender, EventArgs e)
        {
            Mat gray_result = new Mat();
            Mat tm_result = new Mat();
            Mat result = new Mat();
            Rectangle rectangle = new Rectangle();
            Rectangle[] rectangles = new Rectangle[multiple_Count_Main];
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
                if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
                {
                    matching_Main.Template_Single(Og_Image_Mat, Template_Image_Mat, out gray_result, out tm_result, out result, out rectangle, out rank, out similarity, out maxPoint);
                    rectangle_Result = rectangle;
                    maxPoint_Public = maxPoint;
                    similarity_Main = similarity;

                    // listView에 Data 입력
                    ui_listView.Items.Clear();
                    if (similarity >= single_Thr_Main)
                    {
                        this.ui_listViewAdd(rank, similarity, maxPoint);
                    }
                }
                else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
                {
                    matching_Main.Template_Multiple(Og_Image_Mat, Template_Image_Mat, out gray_result, out tm_result, out result, out rectangles, out (int, double, OpenCvSharp.Point)[] tuple_Multiple_arr);
                    rectangles_Result = rectangles;
                    tuple_Multiple_arr_Main = new (int, double, OpenCvSharp.Point)[multiple_Count_Main];
                    tuple_Multiple_arr_Main = tuple_Multiple_arr;

                    // listView에 Data 입력
                    ui_listView.Items.Clear();
                    for (int i = 1; i <= multiple_Count_Main; i++)
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
            // Parameter Form 호출
            Form_Parameter parameter_dlg = new Form_Parameter();

            parameter_dlg.ShowDialog();

            // Parameter Form을 닫을 때 값 받아오기
            single_Thr_Main = parameter_dlg.single_Thr;
            multiple_Count_Main = parameter_dlg.multiple_Count;
            matching_Main.single_Thr_Matching = parameter_dlg.single_Thr;
            matching_Main.multiple_Count_Matching = parameter_dlg.multiple_Count;
            Array.Resize(ref tuple_Multiple_arr_Main, multiple_Count_Main);
        }

        private void ui_button_ExcelSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.xls";
            saveFileDialog.Filter = "Excel Files (*.xls)|*.xls";

            // 엑셀 파일 및 시트 생성
            object misValue = System.Reflection.Missing.Value;
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            Excel.Workbook excelBook = excelApp.Workbooks.Add(misValue);
            Excel.Worksheet excelSheet1 = excelBook.Worksheets.Item["Sheet1"];
            Excel.Worksheet excelSheet2 = (Excel.Worksheet)excelBook.Worksheets.Add(After: excelBook.Worksheets[1]);

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    // 셀 병합
                    Excel.Range range1_Merge_Title = excelSheet1.Range[excelSheet1.Cells[1, 1], excelSheet1.Cells[1, ui_listView.Columns.Count + 2]];
                    range1_Merge_Title.Merge();

                    for (int i = 0; i <= ui_listView.Items.Count; i++)
                    {
                        Excel.Range range1_Merge_Point = excelSheet1.Range[excelSheet1.Cells[i + 3, ui_listView.Columns.Count], excelSheet1.Cells[i + 3, ui_listView.Columns.Count + 1]];
                        range1_Merge_Point.Merge();
                    }

                    excelSheet1.Cells[1, 1].Value = $"{ui_label_Filename.Text}";
                    excelSheet1.Cells[3, ui_listView.Columns.Count + 2].Value = "이미지";

                    // listView에서 1번 시트로 데이터 입력
                    for (int i = 0; i < ui_listView.Items.Count; i++)
                    {
                        for (int j = 0; j < ui_listView.Columns.Count; j++)
                        {
                            if (i == 0)
                            {
                                excelSheet1.Cells[3, j + 1] = this.ui_listView.Columns[j].Text;
                            }
                            excelSheet1.Cells[i + 4, j + 1] = this.ui_listView.Items[i].SubItems[j].Text;
                        }
                    }

                    // 이미지 입력
                    if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
                    {
                        Bitmap Result_Image_Bmp = new Bitmap(ui_imageBox_Result.Image);
                        Bitmap Cropped_Image_Bmp = Result_Image_Bmp.Clone(rectangle_Result, Result_Image_Bmp.PixelFormat);

                        Clipboard.SetImage(Cropped_Image_Bmp);
                        Excel.Range image_Range = (Excel.Range)excelSheet1.Cells[4, ui_listView.Columns.Count + 2];
                        excelSheet1.Paste(image_Range);
                    }
                    else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
                    {
                        for (int i = 0; i < ui_listView.Items.Count; i++)
                        {
                            Bitmap Result_Image_Bmp = new Bitmap(ui_imageBox_Result.Image);
                            Bitmap Cropped_Image_Bmp = Result_Image_Bmp.Clone(rectangles_Result[i], Result_Image_Bmp.PixelFormat);

                            Clipboard.SetImage(Cropped_Image_Bmp);
                            Excel.Range image_Range = (Excel.Range)excelSheet1.Cells[i + 4, ui_listView.Columns.Count + 2];
                            excelSheet1.Paste(image_Range);
                        }
                    }

                    // 셀 서식 변경
                    Excel.Range range1_All = excelSheet1.Range[excelSheet1.Cells[1, 1], excelSheet1.Cells[ui_listView.Items.Count + 3, ui_listView.Columns.Count + 2]];
                    Excel.Range range1_Items = excelSheet1.Range[excelSheet1.Cells[4, 1], excelSheet1.Cells[ui_listView.Items.Count + 3, ui_listView.Columns.Count + 2]];
                    range1_All.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range1_All.HorizontalAlignment = 3;
                    range1_All.VerticalAlignment = 2;
                    range1_Items.RowHeight = 119;
                    excelSheet1.Columns[ui_listView.Columns.Count + 2].ColumnWidth = 19;


                    // 셀 병합
                    Excel.Range range2_Merge_Title = excelSheet2.Range[excelSheet2.Cells[1, 1], excelSheet2.Cells[1, ui_listView.Columns.Count + 2]];
                    range2_Merge_Title.Merge();

                    for (int i = 0; i <= ui_listView.Items.Count; i++)
                    {
                        Excel.Range range2_Merge = excelSheet2.Range[excelSheet2.Cells[i + 3, ui_listView.Columns.Count - 1], excelSheet2.Cells[i + 3, ui_listView.Columns.Count]];
                        range2_Merge.Merge();
                    }

                    excelSheet2.Cells[1, 1].Value = $"{ui_label_Filename.Text}";
                    excelSheet2.Cells[3, ui_listView.Columns.Count + 2].Value = "이미지";

                    // listView에서 2번 시트로 데이터 입력
                    for (int i = 0; i < ui_listView.Items.Count; i++)
                    {
                        for (int j = 0; j < ui_listView.Columns.Count; j++)
                        {
                            if (i == 0)
                            {
                                switch (j)
                                {
                                    case 1:
                                        excelSheet2.Cells[3, j + 3] = this.ui_listView.Columns[j].Text;
                                        break;
                                    case 2:
                                        excelSheet2.Cells[3, j] = this.ui_listView.Columns[j].Text;
                                        break;
                                    default:
                                        excelSheet2.Cells[3, j + 1] = this.ui_listView.Columns[j].Text;
                                        break;
                                }
                            }
                            switch (j)
                            {
                                case 1:
                                    excelSheet2.Cells[i + 4, j + 3] = this.ui_listView.Items[i].SubItems[j].Text;
                                    break;
                                case 2:
                                    excelSheet2.Cells[i + 4, j] = this.ui_listView.Items[i].SubItems[j].Text;
                                    break;
                                default:
                                    excelSheet2.Cells[i + 4, j + 1] = this.ui_listView.Items[i].SubItems[j].Text;
                                    break;
                            }
                        }
                    }

                    // 이미지 입력
                    if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
                    {
                        Bitmap Result_Image_Bmp = new Bitmap(ui_imageBox_Result.Image);
                        Bitmap Cropped_Image_Bmp = Result_Image_Bmp.Clone(rectangle_Result, Result_Image_Bmp.PixelFormat);

                        Clipboard.SetImage(Cropped_Image_Bmp);
                        Excel.Range image_Range = (Excel.Range)excelSheet2.Cells[4, ui_listView.Columns.Count + 2];
                        excelSheet2.Paste(image_Range);
                    }
                    else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
                    {
                        for (int i = 0; i < ui_listView.Items.Count; i++)
                        {
                            Bitmap Result_Image_Bmp = new Bitmap(ui_imageBox_Result.Image);
                            Bitmap Cropped_Image_Bmp = Result_Image_Bmp.Clone(rectangles_Result[i], Result_Image_Bmp.PixelFormat);

                            Clipboard.SetImage(Cropped_Image_Bmp);
                            Excel.Range image_Range = (Excel.Range)excelSheet2.Cells[i + 4, ui_listView.Columns.Count + 2];
                            excelSheet2.Paste(image_Range);
                        }
                    }

                    // 셀 서식 변경
                    Excel.Range range2_All = excelSheet2.Range[excelSheet2.Cells[1, 1], excelSheet2.Cells[ui_listView.Items.Count + 3, ui_listView.Columns.Count + 2]];
                    Excel.Range range2_Items = excelSheet2.Range[excelSheet2.Cells[4, 1], excelSheet2.Cells[ui_listView.Items.Count + 3, ui_listView.Columns.Count + 2]];
                    range2_All.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range2_All.HorizontalAlignment = 3;
                    range2_All.VerticalAlignment = 2;
                    range2_Items.RowHeight = 119;
                    excelSheet2.Columns[ui_listView.Columns.Count + 2].ColumnWidth = 19;

                    // 엑셀 파일 저장
                    excelSheet1.Activate();
                    excelBook.SaveAs(@saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                    excelBook.Close(false, misValue, misValue);
                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelSheet1);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelSheet2);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }

        }

        #endregion

        #region listView

        private void ui_listViewAdd(int rank, double similarity, OpenCvSharp.Point maxPoint)
        {
            ui_listView.BeginUpdate();

            ListViewItem ui_listViewItem = new ListViewItem(rank.ToString());
            ui_listViewItem.SubItems.Add($"{Math.Round(similarity, 3)}");
            ui_listViewItem.SubItems.Add($"({maxPoint.X}, {maxPoint.Y})");
            ui_listView.Items.Add(ui_listViewItem);

            ui_listView.EndUpdate();

            ui_button_ExcelSave.Enabled = true;
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

        #endregion

        #region imageBox

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
                    //ui_toolTip_Result.Active = true;
                    ui_toolTip_Result.SetToolTip(ui_imageBox_Result, $"유사도: {Math.Round(similarity_Main, 3)}");
                }
                else
                {
                    //ui_toolTip_Result.Active = false;
                }
            }
            else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
            {
                for (int rectIndex = 0; rectIndex < multiple_Count_Main; ++rectIndex)
                {
                    Rectangle resultRectangle = new Rectangle(tuple_Multiple_arr_Main[rectIndex].Item3.X, tuple_Multiple_arr_Main[rectIndex].Item3.Y, Template_Image_Mat.Width, Template_Image_Mat.Height);
                    if (resultRectangle.Contains(resultPoint.X, resultPoint.Y))
                    {
                        ui_toolTip_Result.SetToolTip(ui_imageBox_Result, $"유사도: {Math.Round(tuple_Multiple_arr_Main[rectIndex].Item2, 3)}");
                        break;
                    }
                }
            }
        }

        private void Draw_Rectangle(object sender, PaintEventArgs e)
        {
            if (TemplateMatching.Properties.Settings.Default.radioSingle == true)
            {
                Rectangle rect = new Rectangle();
                rect = ui_imageBox_Result.GetOffsetRectangle(rectangle_Result);
                Graphics grp = e.Graphics;
                Pen pen = new Pen(Color.Red, 3);
                grp.DrawRectangle(pen, rect);
            }
            else if (TemplateMatching.Properties.Settings.Default.radioMultiple == true)
            {
                Rectangle[] rects = new Rectangle[multiple_Count_Main];
                for (int i = 1; i <= multiple_Count_Main; i++)
                {
                    rects[i - 1] = ui_imageBox_Result.GetOffsetRectangle(rectangles_Result[i - 1]);
                    Graphics grp = e.Graphics;
                    Pen pen = new Pen(Color.Red, 3);
                    grp.DrawRectangle(pen, rects[i - 1]);
                    grp.DrawString($"{i}", new Font("Consolas", 20), new SolidBrush(Color.Red), rects[i - 1].X - 15, rects[i - 1].Y - 30);
                }

            }
        }

        #endregion

    }
}
