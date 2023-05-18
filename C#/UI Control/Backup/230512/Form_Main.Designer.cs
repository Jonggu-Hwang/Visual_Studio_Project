namespace TM_UI
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.UI_tableLayoutBack = new System.Windows.Forms.TableLayoutPanel();
            this.UI_tableLayout_Temp = new System.Windows.Forms.TableLayoutPanel();
            this.ui_imageBox_Temp = new Cyotek.Windows.Forms.ImageBox();
            this.ui_listView = new System.Windows.Forms.ListView();
            this.ui_columnHeader_Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ui_columnHeader_Sim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ui_columnHeader_Point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ui_label_Template = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_label_Time = new System.Windows.Forms.Label();
            this.ui_pictureBox_LVI = new System.Windows.Forms.PictureBox();
            this.ui_tableLayoutImage = new System.Windows.Forms.TableLayoutPanel();
            this.UI_tabControl = new System.Windows.Forms.TabControl();
            this.UI_tabPage_Og = new System.Windows.Forms.TabPage();
            this.ui_imageBox_Og = new Cyotek.Windows.Forms.ImageBox();
            this.UI_tabPage_Gray = new System.Windows.Forms.TabPage();
            this.ui_imageBox_Gray = new Cyotek.Windows.Forms.ImageBox();
            this.UI_tabPage_Sim = new System.Windows.Forms.TabPage();
            this.ui_imageBox_Sim = new Cyotek.Windows.Forms.ImageBox();
            this.UI_tabPage_Result = new System.Windows.Forms.TabPage();
            this.ui_imageBox_Result = new Cyotek.Windows.Forms.ImageBox();
            this.ui_tableLayoutBtn = new System.Windows.Forms.TableLayoutPanel();
            this.ui_ImageLoadBtn = new System.Windows.Forms.Button();
            this.ui_TempLoadBtn = new System.Windows.Forms.Button();
            this.ui_ParameterBtn = new System.Windows.Forms.Button();
            this.ui_MatchingBtn = new System.Windows.Forms.Button();
            this.ui_tableLayoutPanel_Status = new System.Windows.Forms.TableLayoutPanel();
            this.ui_label_Point = new System.Windows.Forms.Label();
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.ui_toolTip_Result = new System.Windows.Forms.ToolTip(this.components);
            this.ui_label_Filename = new System.Windows.Forms.Label();
            this.UI_tableLayoutBack.SuspendLayout();
            this.UI_tableLayout_Temp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pictureBox_LVI)).BeginInit();
            this.ui_tableLayoutImage.SuspendLayout();
            this.UI_tabControl.SuspendLayout();
            this.UI_tabPage_Og.SuspendLayout();
            this.UI_tabPage_Gray.SuspendLayout();
            this.UI_tabPage_Sim.SuspendLayout();
            this.UI_tabPage_Result.SuspendLayout();
            this.ui_tableLayoutBtn.SuspendLayout();
            this.ui_tableLayoutPanel_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_tableLayoutBack
            // 
            this.UI_tableLayoutBack.ColumnCount = 3;
            this.UI_tableLayoutBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.UI_tableLayoutBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.UI_tableLayoutBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UI_tableLayoutBack.Controls.Add(this.UI_tableLayout_Temp, 2, 0);
            this.UI_tableLayoutBack.Controls.Add(this.ui_tableLayoutImage, 0, 0);
            this.UI_tableLayoutBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_tableLayoutBack.Location = new System.Drawing.Point(0, 0);
            this.UI_tableLayoutBack.Name = "UI_tableLayoutBack";
            this.UI_tableLayoutBack.RowCount = 1;
            this.UI_tableLayoutBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UI_tableLayoutBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UI_tableLayoutBack.Size = new System.Drawing.Size(1235, 930);
            this.UI_tableLayoutBack.TabIndex = 6;
            // 
            // UI_tableLayout_Temp
            // 
            this.UI_tableLayout_Temp.ColumnCount = 1;
            this.UI_tableLayout_Temp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UI_tableLayout_Temp.Controls.Add(this.ui_imageBox_Temp, 0, 1);
            this.UI_tableLayout_Temp.Controls.Add(this.ui_listView, 0, 3);
            this.UI_tableLayout_Temp.Controls.Add(this.ui_label_Template, 0, 0);
            this.UI_tableLayout_Temp.Controls.Add(this.label1, 0, 2);
            this.UI_tableLayout_Temp.Controls.Add(this.ui_label_Time, 0, 5);
            this.UI_tableLayout_Temp.Controls.Add(this.ui_pictureBox_LVI, 0, 4);
            this.UI_tableLayout_Temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_tableLayout_Temp.Location = new System.Drawing.Point(842, 3);
            this.UI_tableLayout_Temp.Name = "UI_tableLayout_Temp";
            this.UI_tableLayout_Temp.RowCount = 6;
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.UI_tableLayout_Temp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.UI_tableLayout_Temp.Size = new System.Drawing.Size(390, 924);
            this.UI_tableLayout_Temp.TabIndex = 9;
            // 
            // ui_imageBox_Temp
            // 
            this.ui_imageBox_Temp.AllowZoom = false;
            this.ui_imageBox_Temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_imageBox_Temp.GridColor = System.Drawing.Color.White;
            this.ui_imageBox_Temp.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.ui_imageBox_Temp.Location = new System.Drawing.Point(3, 23);
            this.ui_imageBox_Temp.Name = "ui_imageBox_Temp";
            this.ui_imageBox_Temp.Padding = new System.Windows.Forms.Padding(3);
            this.ui_imageBox_Temp.Size = new System.Drawing.Size(384, 384);
            this.ui_imageBox_Temp.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.ui_imageBox_Temp.TabIndex = 0;
            // 
            // ui_listView
            // 
            this.ui_listView.BackColor = System.Drawing.SystemColors.Window;
            this.ui_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ui_columnHeader_Rank,
            this.ui_columnHeader_Sim,
            this.ui_columnHeader_Point});
            this.ui_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_listView.GridLines = true;
            this.ui_listView.HideSelection = false;
            this.ui_listView.Location = new System.Drawing.Point(0, 445);
            this.ui_listView.Margin = new System.Windows.Forms.Padding(0);
            this.ui_listView.Name = "ui_listView";
            this.ui_listView.Size = new System.Drawing.Size(390, 355);
            this.ui_listView.TabIndex = 15;
            this.ui_listView.UseCompatibleStateImageBehavior = false;
            this.ui_listView.View = System.Windows.Forms.View.Details;
            this.ui_listView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ui_listView_ColumnWidthChanging);
            // 
            // ui_columnHeader_Rank
            // 
            this.ui_columnHeader_Rank.Text = "순위";
            this.ui_columnHeader_Rank.Width = 74;
            // 
            // ui_columnHeader_Sim
            // 
            this.ui_columnHeader_Sim.Text = "유사도";
            this.ui_columnHeader_Sim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_columnHeader_Sim.Width = 116;
            // 
            // ui_columnHeader_Point
            // 
            this.ui_columnHeader_Point.Text = "좌표";
            this.ui_columnHeader_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_columnHeader_Point.Width = 196;
            // 
            // ui_label_Template
            // 
            this.ui_label_Template.AutoSize = true;
            this.ui_label_Template.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_label_Template.Location = new System.Drawing.Point(3, 5);
            this.ui_label_Template.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ui_label_Template.Name = "ui_label_Template";
            this.ui_label_Template.Size = new System.Drawing.Size(384, 12);
            this.ui_label_Template.TabIndex = 16;
            this.ui_label_Template.Text = "Template";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data";
            // 
            // ui_label_Time
            // 
            this.ui_label_Time.AutoSize = true;
            this.ui_label_Time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_label_Time.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_label_Time.Location = new System.Drawing.Point(3, 907);
            this.ui_label_Time.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ui_label_Time.Name = "ui_label_Time";
            this.ui_label_Time.Size = new System.Drawing.Size(384, 12);
            this.ui_label_Time.TabIndex = 13;
            this.ui_label_Time.Text = "ui_label_Time";
            this.ui_label_Time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ui_pictureBox_LVI
            // 
            this.ui_pictureBox_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_pictureBox_LVI.Image = ((System.Drawing.Image)(resources.GetObject("ui_pictureBox_LVI.Image")));
            this.ui_pictureBox_LVI.Location = new System.Drawing.Point(3, 803);
            this.ui_pictureBox_LVI.Name = "ui_pictureBox_LVI";
            this.ui_pictureBox_LVI.Size = new System.Drawing.Size(384, 100);
            this.ui_pictureBox_LVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ui_pictureBox_LVI.TabIndex = 18;
            this.ui_pictureBox_LVI.TabStop = false;
            // 
            // ui_tableLayoutImage
            // 
            this.ui_tableLayoutImage.ColumnCount = 1;
            this.ui_tableLayoutImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_tableLayoutImage.Controls.Add(this.UI_tabControl, 0, 0);
            this.ui_tableLayoutImage.Controls.Add(this.ui_tableLayoutBtn, 0, 2);
            this.ui_tableLayoutImage.Controls.Add(this.ui_tableLayoutPanel_Status, 0, 1);
            this.ui_tableLayoutImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tableLayoutImage.Location = new System.Drawing.Point(0, 0);
            this.ui_tableLayoutImage.Margin = new System.Windows.Forms.Padding(0);
            this.ui_tableLayoutImage.Name = "ui_tableLayoutImage";
            this.ui_tableLayoutImage.RowCount = 4;
            this.ui_tableLayoutImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.ui_tableLayoutImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ui_tableLayoutImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ui_tableLayoutImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_tableLayoutImage.Size = new System.Drawing.Size(789, 930);
            this.ui_tableLayoutImage.TabIndex = 10;
            // 
            // UI_tabControl
            // 
            this.UI_tabControl.Controls.Add(this.UI_tabPage_Og);
            this.UI_tabControl.Controls.Add(this.UI_tabPage_Gray);
            this.UI_tabControl.Controls.Add(this.UI_tabPage_Sim);
            this.UI_tabControl.Controls.Add(this.UI_tabPage_Result);
            this.UI_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_tabControl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UI_tabControl.Location = new System.Drawing.Point(0, 0);
            this.UI_tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.UI_tabControl.Name = "UI_tabControl";
            this.UI_tabControl.SelectedIndex = 0;
            this.UI_tabControl.Size = new System.Drawing.Size(789, 805);
            this.UI_tabControl.TabIndex = 11;
            // 
            // UI_tabPage_Og
            // 
            this.UI_tabPage_Og.BackColor = System.Drawing.Color.Transparent;
            this.UI_tabPage_Og.Controls.Add(this.ui_imageBox_Og);
            this.UI_tabPage_Og.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_tabPage_Og.Location = new System.Drawing.Point(4, 23);
            this.UI_tabPage_Og.Name = "UI_tabPage_Og";
            this.UI_tabPage_Og.Padding = new System.Windows.Forms.Padding(3);
            this.UI_tabPage_Og.Size = new System.Drawing.Size(781, 778);
            this.UI_tabPage_Og.TabIndex = 0;
            this.UI_tabPage_Og.Text = "원본 이미지";
            this.UI_tabPage_Og.UseVisualStyleBackColor = true;
            // 
            // ui_imageBox_Og
            // 
            this.ui_imageBox_Og.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_imageBox_Og.GridColor = System.Drawing.Color.White;
            this.ui_imageBox_Og.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.ui_imageBox_Og.Location = new System.Drawing.Point(3, 3);
            this.ui_imageBox_Og.Margin = new System.Windows.Forms.Padding(0);
            this.ui_imageBox_Og.Name = "ui_imageBox_Og";
            this.ui_imageBox_Og.Size = new System.Drawing.Size(775, 772);
            this.ui_imageBox_Og.TabIndex = 9;
            this.ui_imageBox_Og.ImageChanged += new System.EventHandler(this.ui_imageBox_Og_ImageChanged);
            this.ui_imageBox_Og.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_imageBox_Og_MouseMove);
            // 
            // UI_tabPage_Gray
            // 
            this.UI_tabPage_Gray.Controls.Add(this.ui_imageBox_Gray);
            this.UI_tabPage_Gray.Location = new System.Drawing.Point(4, 23);
            this.UI_tabPage_Gray.Name = "UI_tabPage_Gray";
            this.UI_tabPage_Gray.Padding = new System.Windows.Forms.Padding(3);
            this.UI_tabPage_Gray.Size = new System.Drawing.Size(781, 778);
            this.UI_tabPage_Gray.TabIndex = 1;
            this.UI_tabPage_Gray.Text = "Grayscale 이미지";
            this.UI_tabPage_Gray.UseVisualStyleBackColor = true;
            // 
            // ui_imageBox_Gray
            // 
            this.ui_imageBox_Gray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_imageBox_Gray.GridColor = System.Drawing.Color.White;
            this.ui_imageBox_Gray.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.ui_imageBox_Gray.Location = new System.Drawing.Point(3, 3);
            this.ui_imageBox_Gray.Name = "ui_imageBox_Gray";
            this.ui_imageBox_Gray.Size = new System.Drawing.Size(775, 772);
            this.ui_imageBox_Gray.TabIndex = 10;
            this.ui_imageBox_Gray.ImageChanged += new System.EventHandler(this.ui_imageBox_Gray_ImageChanged);
            this.ui_imageBox_Gray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_imageBox_Gray_MouseMove);
            // 
            // UI_tabPage_Sim
            // 
            this.UI_tabPage_Sim.Controls.Add(this.ui_imageBox_Sim);
            this.UI_tabPage_Sim.Location = new System.Drawing.Point(4, 23);
            this.UI_tabPage_Sim.Name = "UI_tabPage_Sim";
            this.UI_tabPage_Sim.Padding = new System.Windows.Forms.Padding(3);
            this.UI_tabPage_Sim.Size = new System.Drawing.Size(781, 778);
            this.UI_tabPage_Sim.TabIndex = 2;
            this.UI_tabPage_Sim.Text = "유사도 행렬";
            this.UI_tabPage_Sim.UseVisualStyleBackColor = true;
            // 
            // ui_imageBox_Sim
            // 
            this.ui_imageBox_Sim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_imageBox_Sim.GridColor = System.Drawing.Color.White;
            this.ui_imageBox_Sim.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.ui_imageBox_Sim.Location = new System.Drawing.Point(3, 3);
            this.ui_imageBox_Sim.Margin = new System.Windows.Forms.Padding(0);
            this.ui_imageBox_Sim.Name = "ui_imageBox_Sim";
            this.ui_imageBox_Sim.Size = new System.Drawing.Size(775, 772);
            this.ui_imageBox_Sim.TabIndex = 11;
            this.ui_imageBox_Sim.ImageChanged += new System.EventHandler(this.ui_imageBox_Sim_ImageChanged);
            this.ui_imageBox_Sim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_imageBox_Sim_MouseMove);
            // 
            // UI_tabPage_Result
            // 
            this.UI_tabPage_Result.Controls.Add(this.ui_imageBox_Result);
            this.UI_tabPage_Result.Location = new System.Drawing.Point(4, 23);
            this.UI_tabPage_Result.Name = "UI_tabPage_Result";
            this.UI_tabPage_Result.Padding = new System.Windows.Forms.Padding(3);
            this.UI_tabPage_Result.Size = new System.Drawing.Size(781, 778);
            this.UI_tabPage_Result.TabIndex = 3;
            this.UI_tabPage_Result.Text = "매칭 결과";
            this.UI_tabPage_Result.UseVisualStyleBackColor = true;
            // 
            // ui_imageBox_Result
            // 
            this.ui_imageBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_imageBox_Result.GridColor = System.Drawing.Color.White;
            this.ui_imageBox_Result.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.ui_imageBox_Result.Location = new System.Drawing.Point(3, 3);
            this.ui_imageBox_Result.Margin = new System.Windows.Forms.Padding(0);
            this.ui_imageBox_Result.Name = "ui_imageBox_Result";
            this.ui_imageBox_Result.Size = new System.Drawing.Size(775, 772);
            this.ui_imageBox_Result.TabIndex = 11;
            this.ui_imageBox_Result.ImageChanged += new System.EventHandler(this.ui_imageBox_Result_ImageChanged);
            this.ui_imageBox_Result.MouseHover += new System.EventHandler(this.ui_imageBox_Result_MouseHover);
            this.ui_imageBox_Result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ui_imageBox_Result_MouseMove);
            // 
            // ui_tableLayoutBtn
            // 
            this.ui_tableLayoutBtn.ColumnCount = 7;
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_tableLayoutBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutBtn.Controls.Add(this.ui_ImageLoadBtn, 0, 1);
            this.ui_tableLayoutBtn.Controls.Add(this.ui_TempLoadBtn, 2, 1);
            this.ui_tableLayoutBtn.Controls.Add(this.ui_ParameterBtn, 4, 1);
            this.ui_tableLayoutBtn.Controls.Add(this.ui_MatchingBtn, 6, 1);
            this.ui_tableLayoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tableLayoutBtn.Location = new System.Drawing.Point(3, 833);
            this.ui_tableLayoutBtn.Name = "ui_tableLayoutBtn";
            this.ui_tableLayoutBtn.RowCount = 2;
            this.ui_tableLayoutBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ui_tableLayoutBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_tableLayoutBtn.Size = new System.Drawing.Size(783, 83);
            this.ui_tableLayoutBtn.TabIndex = 12;
            // 
            // ui_ImageLoadBtn
            // 
            this.ui_ImageLoadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_ImageLoadBtn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.ui_ImageLoadBtn.Location = new System.Drawing.Point(3, 23);
            this.ui_ImageLoadBtn.Name = "ui_ImageLoadBtn";
            this.ui_ImageLoadBtn.Size = new System.Drawing.Size(182, 57);
            this.ui_ImageLoadBtn.TabIndex = 7;
            this.ui_ImageLoadBtn.Text = "Image Load\r\n";
            this.ui_ImageLoadBtn.UseVisualStyleBackColor = true;
            this.ui_ImageLoadBtn.Click += new System.EventHandler(this.ui_ImageLoadBtn_Click);
            // 
            // ui_TempLoadBtn
            // 
            this.ui_TempLoadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_TempLoadBtn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.ui_TempLoadBtn.Location = new System.Drawing.Point(201, 23);
            this.ui_TempLoadBtn.Name = "ui_TempLoadBtn";
            this.ui_TempLoadBtn.Size = new System.Drawing.Size(182, 57);
            this.ui_TempLoadBtn.TabIndex = 8;
            this.ui_TempLoadBtn.Text = "Template Load";
            this.ui_TempLoadBtn.UseVisualStyleBackColor = true;
            this.ui_TempLoadBtn.Click += new System.EventHandler(this.ui_TempLoadBtn_Click);
            // 
            // ui_ParameterBtn
            // 
            this.ui_ParameterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_ParameterBtn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.ui_ParameterBtn.Location = new System.Drawing.Point(399, 23);
            this.ui_ParameterBtn.Name = "ui_ParameterBtn";
            this.ui_ParameterBtn.Size = new System.Drawing.Size(182, 57);
            this.ui_ParameterBtn.TabIndex = 10;
            this.ui_ParameterBtn.Text = "Parameter Setup";
            this.ui_ParameterBtn.UseVisualStyleBackColor = true;
            this.ui_ParameterBtn.Click += new System.EventHandler(this.ui_ParameterBtn_Click);
            // 
            // ui_MatchingBtn
            // 
            this.ui_MatchingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_MatchingBtn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.ui_MatchingBtn.Location = new System.Drawing.Point(597, 23);
            this.ui_MatchingBtn.Name = "ui_MatchingBtn";
            this.ui_MatchingBtn.Size = new System.Drawing.Size(183, 57);
            this.ui_MatchingBtn.TabIndex = 9;
            this.ui_MatchingBtn.Text = "Template Matching";
            this.ui_MatchingBtn.UseVisualStyleBackColor = true;
            this.ui_MatchingBtn.Click += new System.EventHandler(this.ui_MatchingBtn_Click);
            // 
            // ui_tableLayoutPanel_Status
            // 
            this.ui_tableLayoutPanel_Status.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.ui_tableLayoutPanel_Status.ColumnCount = 2;
            this.ui_tableLayoutPanel_Status.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ui_tableLayoutPanel_Status.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ui_tableLayoutPanel_Status.Controls.Add(this.ui_label_Filename, 0, 0);
            this.ui_tableLayoutPanel_Status.Controls.Add(this.ui_label_Point, 1, 0);
            this.ui_tableLayoutPanel_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tableLayoutPanel_Status.Location = new System.Drawing.Point(3, 805);
            this.ui_tableLayoutPanel_Status.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ui_tableLayoutPanel_Status.Name = "ui_tableLayoutPanel_Status";
            this.ui_tableLayoutPanel_Status.RowCount = 1;
            this.ui_tableLayoutPanel_Status.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_tableLayoutPanel_Status.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ui_tableLayoutPanel_Status.Size = new System.Drawing.Size(783, 25);
            this.ui_tableLayoutPanel_Status.TabIndex = 13;
            // 
            // ui_label_Point
            // 
            this.ui_label_Point.Dock = System.Windows.Forms.DockStyle.Right;
            this.ui_label_Point.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_label_Point.Location = new System.Drawing.Point(395, 3);
            this.ui_label_Point.Margin = new System.Windows.Forms.Padding(0);
            this.ui_label_Point.Name = "ui_label_Point";
            this.ui_label_Point.Size = new System.Drawing.Size(385, 19);
            this.ui_label_Point.TabIndex = 15;
            this.ui_label_Point.Text = "좌표 (X, Y): ()";
            this.ui_label_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_Sec
            // 
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // ui_toolTip_Result
            // 
            this.ui_toolTip_Result.AutomaticDelay = 750;
            this.ui_toolTip_Result.ShowAlways = true;
            // 
            // ui_label_Filename
            // 
            this.ui_label_Filename.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_label_Filename.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_label_Filename.Location = new System.Drawing.Point(3, 3);
            this.ui_label_Filename.Margin = new System.Windows.Forms.Padding(0);
            this.ui_label_Filename.Name = "ui_label_Filename";
            this.ui_label_Filename.Size = new System.Drawing.Size(385, 19);
            this.ui_label_Filename.TabIndex = 16;
            this.ui_label_Filename.Text = "File name: ";
            this.ui_label_Filename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 930);
            this.Controls.Add(this.UI_tableLayoutBack);
            this.Name = "Form_Main";
            this.Text = "Template Matching";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Main_SizeChanged);
            this.UI_tableLayoutBack.ResumeLayout(false);
            this.UI_tableLayout_Temp.ResumeLayout(false);
            this.UI_tableLayout_Temp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pictureBox_LVI)).EndInit();
            this.ui_tableLayoutImage.ResumeLayout(false);
            this.UI_tabControl.ResumeLayout(false);
            this.UI_tabPage_Og.ResumeLayout(false);
            this.UI_tabPage_Gray.ResumeLayout(false);
            this.UI_tabPage_Sim.ResumeLayout(false);
            this.UI_tabPage_Result.ResumeLayout(false);
            this.ui_tableLayoutBtn.ResumeLayout(false);
            this.ui_tableLayoutPanel_Status.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel UI_tableLayoutBack;
        private System.Windows.Forms.TableLayoutPanel UI_tableLayout_Temp;
        private Cyotek.Windows.Forms.ImageBox ui_imageBox_Temp;
        private System.Windows.Forms.Button ui_TempLoadBtn;
        private System.Windows.Forms.Button ui_MatchingBtn;
        private System.Windows.Forms.Button ui_ParameterBtn;
        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutImage;
        private System.Windows.Forms.TabControl UI_tabControl;
        private System.Windows.Forms.TabPage UI_tabPage_Og;
        private Cyotek.Windows.Forms.ImageBox ui_imageBox_Og;
        private System.Windows.Forms.TabPage UI_tabPage_Gray;
        private Cyotek.Windows.Forms.ImageBox ui_imageBox_Gray;
        private System.Windows.Forms.TabPage UI_tabPage_Sim;
        private Cyotek.Windows.Forms.ImageBox ui_imageBox_Sim;
        private System.Windows.Forms.TabPage UI_tabPage_Result;
        private Cyotek.Windows.Forms.ImageBox ui_imageBox_Result;
        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutBtn;
        private System.Windows.Forms.Label ui_label_Time;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.ListView ui_listView;
        private System.Windows.Forms.ColumnHeader ui_columnHeader_Rank;
        private System.Windows.Forms.ColumnHeader ui_columnHeader_Sim;
        private System.Windows.Forms.ColumnHeader ui_columnHeader_Point;
        private System.Windows.Forms.Label ui_label_Template;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ui_toolTip_Result;
        private System.Windows.Forms.PictureBox ui_pictureBox_LVI;
        private System.Windows.Forms.Button ui_ImageLoadBtn;
        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutPanel_Status;
        private System.Windows.Forms.Label ui_label_Point;
        private System.Windows.Forms.Label ui_label_Filename;
    }
}

