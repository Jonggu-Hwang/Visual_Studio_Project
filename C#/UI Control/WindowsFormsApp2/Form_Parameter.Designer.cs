namespace TM_Parameter
{
    partial class Form_Parameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ui_tableLayoutPanel_Para = new System.Windows.Forms.TableLayoutPanel();
            this.ui_panel_Single = new System.Windows.Forms.Panel();
            this.ui_panel_Multiple = new System.Windows.Forms.Panel();
            this.ui_textBox_Multiple_Count = new System.Windows.Forms.TextBox();
            this.ui_label_Multiple_Count = new System.Windows.Forms.Label();
            this.ui_label_Single_Thr = new System.Windows.Forms.Label();
            this.ui_textBox_Single_Thr = new System.Windows.Forms.TextBox();
            this.ui_tableLayoutPanel_ParaBtn = new System.Windows.Forms.TableLayoutPanel();
            this.ui_button_Para_OK = new System.Windows.Forms.Button();
            this.ui_button_Para_Cancel = new System.Windows.Forms.Button();
            this.ui_radioButton_Single = new System.Windows.Forms.RadioButton();
            this.ui_radioButton_Multiple = new System.Windows.Forms.RadioButton();
            this.ui_button_XmlSave = new System.Windows.Forms.Button();
            this.ui_button_XmlLoad = new System.Windows.Forms.Button();
            this.ui_tableLayoutPanel_Para.SuspendLayout();
            this.ui_panel_Single.SuspendLayout();
            this.ui_panel_Multiple.SuspendLayout();
            this.ui_tableLayoutPanel_ParaBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_tableLayoutPanel_Para
            // 
            this.ui_tableLayoutPanel_Para.ColumnCount = 2;
            this.ui_tableLayoutPanel_Para.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ui_tableLayoutPanel_Para.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_panel_Single, 0, 3);
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_tableLayoutPanel_ParaBtn, 0, 4);
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_radioButton_Single, 0, 2);
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_radioButton_Multiple, 1, 2);
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_button_XmlSave, 0, 1);
            this.ui_tableLayoutPanel_Para.Controls.Add(this.ui_button_XmlLoad, 1, 1);
            this.ui_tableLayoutPanel_Para.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tableLayoutPanel_Para.Location = new System.Drawing.Point(0, 0);
            this.ui_tableLayoutPanel_Para.Name = "ui_tableLayoutPanel_Para";
            this.ui_tableLayoutPanel_Para.RowCount = 6;
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.99995F));
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66995F));
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.99991F));
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33018F));
            this.ui_tableLayoutPanel_Para.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ui_tableLayoutPanel_Para.Size = new System.Drawing.Size(284, 261);
            this.ui_tableLayoutPanel_Para.TabIndex = 0;
            // 
            // ui_panel_Single
            // 
            this.ui_tableLayoutPanel_Para.SetColumnSpan(this.ui_panel_Single, 2);
            this.ui_panel_Single.Controls.Add(this.ui_panel_Multiple);
            this.ui_panel_Single.Controls.Add(this.ui_label_Single_Thr);
            this.ui_panel_Single.Controls.Add(this.ui_textBox_Single_Thr);
            this.ui_panel_Single.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panel_Single.Location = new System.Drawing.Point(3, 92);
            this.ui_panel_Single.Name = "ui_panel_Single";
            this.ui_panel_Single.Size = new System.Drawing.Size(278, 71);
            this.ui_panel_Single.TabIndex = 1;
            // 
            // ui_panel_Multiple
            // 
            this.ui_panel_Multiple.Controls.Add(this.ui_textBox_Multiple_Count);
            this.ui_panel_Multiple.Controls.Add(this.ui_label_Multiple_Count);
            this.ui_panel_Multiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panel_Multiple.Location = new System.Drawing.Point(0, 0);
            this.ui_panel_Multiple.Name = "ui_panel_Multiple";
            this.ui_panel_Multiple.Size = new System.Drawing.Size(278, 71);
            this.ui_panel_Multiple.TabIndex = 2;
            this.ui_panel_Multiple.Visible = false;
            // 
            // ui_textBox_Multiple_Count
            // 
            this.ui_textBox_Multiple_Count.Location = new System.Drawing.Point(141, 45);
            this.ui_textBox_Multiple_Count.Name = "ui_textBox_Multiple_Count";
            this.ui_textBox_Multiple_Count.Size = new System.Drawing.Size(100, 21);
            this.ui_textBox_Multiple_Count.TabIndex = 3;
            this.ui_textBox_Multiple_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ui_textBox_Multiple_Count_KeyPress);
            // 
            // ui_label_Multiple_Count
            // 
            this.ui_label_Multiple_Count.Location = new System.Drawing.Point(97, 48);
            this.ui_label_Multiple_Count.Name = "ui_label_Multiple_Count";
            this.ui_label_Multiple_Count.Size = new System.Drawing.Size(38, 12);
            this.ui_label_Multiple_Count.TabIndex = 2;
            this.ui_label_Multiple_Count.Text = "Count";
            // 
            // ui_label_Single_Thr
            // 
            this.ui_label_Single_Thr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_label_Single_Thr.AutoSize = true;
            this.ui_label_Single_Thr.Location = new System.Drawing.Point(73, 48);
            this.ui_label_Single_Thr.Name = "ui_label_Single_Thr";
            this.ui_label_Single_Thr.Size = new System.Drawing.Size(62, 12);
            this.ui_label_Single_Thr.TabIndex = 0;
            this.ui_label_Single_Thr.Text = "Threshold";
            // 
            // ui_textBox_Single_Thr
            // 
            this.ui_textBox_Single_Thr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_textBox_Single_Thr.Location = new System.Drawing.Point(141, 45);
            this.ui_textBox_Single_Thr.Name = "ui_textBox_Single_Thr";
            this.ui_textBox_Single_Thr.Size = new System.Drawing.Size(100, 21);
            this.ui_textBox_Single_Thr.TabIndex = 1;
            this.ui_textBox_Single_Thr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ui_textBox_Single_Thr_KeyPress);
            // 
            // ui_tableLayoutPanel_ParaBtn
            // 
            this.ui_tableLayoutPanel_ParaBtn.ColumnCount = 4;
            this.ui_tableLayoutPanel_Para.SetColumnSpan(this.ui_tableLayoutPanel_ParaBtn, 2);
            this.ui_tableLayoutPanel_ParaBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutPanel_ParaBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutPanel_ParaBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutPanel_ParaBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ui_tableLayoutPanel_ParaBtn.Controls.Add(this.ui_button_Para_OK, 2, 2);
            this.ui_tableLayoutPanel_ParaBtn.Controls.Add(this.ui_button_Para_Cancel, 3, 2);
            this.ui_tableLayoutPanel_ParaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tableLayoutPanel_ParaBtn.Location = new System.Drawing.Point(3, 169);
            this.ui_tableLayoutPanel_ParaBtn.Name = "ui_tableLayoutPanel_ParaBtn";
            this.ui_tableLayoutPanel_ParaBtn.RowCount = 3;
            this.ui_tableLayoutPanel_ParaBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_tableLayoutPanel_ParaBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ui_tableLayoutPanel_ParaBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ui_tableLayoutPanel_ParaBtn.Size = new System.Drawing.Size(278, 67);
            this.ui_tableLayoutPanel_ParaBtn.TabIndex = 0;
            // 
            // ui_button_Para_OK
            // 
            this.ui_button_Para_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_button_Para_OK.Location = new System.Drawing.Point(141, 35);
            this.ui_button_Para_OK.Name = "ui_button_Para_OK";
            this.ui_button_Para_OK.Size = new System.Drawing.Size(63, 29);
            this.ui_button_Para_OK.TabIndex = 0;
            this.ui_button_Para_OK.Text = "확인";
            this.ui_button_Para_OK.UseVisualStyleBackColor = true;
            this.ui_button_Para_OK.Click += new System.EventHandler(this.ui_button_Para_OK_Click);
            // 
            // ui_button_Para_Cancel
            // 
            this.ui_button_Para_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ui_button_Para_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_button_Para_Cancel.Location = new System.Drawing.Point(210, 35);
            this.ui_button_Para_Cancel.Name = "ui_button_Para_Cancel";
            this.ui_button_Para_Cancel.Size = new System.Drawing.Size(65, 29);
            this.ui_button_Para_Cancel.TabIndex = 1;
            this.ui_button_Para_Cancel.Text = "취소";
            this.ui_button_Para_Cancel.UseVisualStyleBackColor = true;
            this.ui_button_Para_Cancel.Click += new System.EventHandler(this.ui_button_Para_Cancel_Click);
            // 
            // ui_radioButton_Single
            // 
            this.ui_radioButton_Single.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ui_radioButton_Single.AutoSize = true;
            this.ui_radioButton_Single.Checked = true;
            this.ui_radioButton_Single.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_radioButton_Single.Location = new System.Drawing.Point(9, 56);
            this.ui_radioButton_Single.Name = "ui_radioButton_Single";
            this.ui_radioButton_Single.Size = new System.Drawing.Size(123, 30);
            this.ui_radioButton_Single.TabIndex = 1;
            this.ui_radioButton_Single.TabStop = true;
            this.ui_radioButton_Single.Text = "최대 유사 지점 매칭";
            this.ui_radioButton_Single.UseVisualStyleBackColor = true;
            this.ui_radioButton_Single.CheckedChanged += new System.EventHandler(this.ui_radioButton_Single_CheckedChanged);
            // 
            // ui_radioButton_Multiple
            // 
            this.ui_radioButton_Multiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ui_radioButton_Multiple.AutoSize = true;
            this.ui_radioButton_Multiple.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_radioButton_Multiple.Location = new System.Drawing.Point(153, 56);
            this.ui_radioButton_Multiple.Name = "ui_radioButton_Multiple";
            this.ui_radioButton_Multiple.Size = new System.Drawing.Size(119, 30);
            this.ui_radioButton_Multiple.TabIndex = 2;
            this.ui_radioButton_Multiple.Text = "유사도 순위별 매칭";
            this.ui_radioButton_Multiple.UseVisualStyleBackColor = true;
            this.ui_radioButton_Multiple.CheckedChanged += new System.EventHandler(this.ui_radioButton_Multiple_CheckedChanged);
            // 
            // ui_button_XmlSave
            // 
            this.ui_button_XmlSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_button_XmlSave.Location = new System.Drawing.Point(3, 23);
            this.ui_button_XmlSave.Name = "ui_button_XmlSave";
            this.ui_button_XmlSave.Size = new System.Drawing.Size(136, 27);
            this.ui_button_XmlSave.TabIndex = 2;
            this.ui_button_XmlSave.Text = "현재 설정 저장";
            this.ui_button_XmlSave.UseMnemonic = false;
            this.ui_button_XmlSave.UseVisualStyleBackColor = true;
            this.ui_button_XmlSave.Click += new System.EventHandler(this.ui_button_XmlSave_Click);
            // 
            // ui_button_XmlLoad
            // 
            this.ui_button_XmlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_button_XmlLoad.Location = new System.Drawing.Point(145, 23);
            this.ui_button_XmlLoad.Name = "ui_button_XmlLoad";
            this.ui_button_XmlLoad.Size = new System.Drawing.Size(136, 27);
            this.ui_button_XmlLoad.TabIndex = 3;
            this.ui_button_XmlLoad.Text = "저장된 설정 불러오기";
            this.ui_button_XmlLoad.UseVisualStyleBackColor = true;
            this.ui_button_XmlLoad.Click += new System.EventHandler(this.ui_button_XmlLoad_Click);
            // 
            // Form_Parameter
            // 
            this.AcceptButton = this.ui_button_Para_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.ui_button_Para_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ui_tableLayoutPanel_Para);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Parameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameter Setup";
            this.Load += new System.EventHandler(this.Form_Parameter_Load);
            this.ui_tableLayoutPanel_Para.ResumeLayout(false);
            this.ui_tableLayoutPanel_Para.PerformLayout();
            this.ui_panel_Single.ResumeLayout(false);
            this.ui_panel_Single.PerformLayout();
            this.ui_panel_Multiple.ResumeLayout(false);
            this.ui_panel_Multiple.PerformLayout();
            this.ui_tableLayoutPanel_ParaBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutPanel_Para;
        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutPanel_ParaBtn;
        private System.Windows.Forms.Button ui_button_Para_OK;
        private System.Windows.Forms.Button ui_button_Para_Cancel;
        private System.Windows.Forms.RadioButton ui_radioButton_Single;
        private System.Windows.Forms.RadioButton ui_radioButton_Multiple;
        private System.Windows.Forms.Panel ui_panel_Multiple;
        private System.Windows.Forms.TextBox ui_textBox_Multiple_Count;
        private System.Windows.Forms.Label ui_label_Multiple_Count;
        private System.Windows.Forms.Panel ui_panel_Single;
        private System.Windows.Forms.Label ui_label_Single_Thr;
        private System.Windows.Forms.TextBox ui_textBox_Single_Thr;
        private System.Windows.Forms.Button ui_button_XmlSave;
        private System.Windows.Forms.Button ui_button_XmlLoad;
    }
}