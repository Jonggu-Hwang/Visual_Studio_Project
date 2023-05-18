namespace P_Invoke_Test_CSharp
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label_Div2 = new System.Windows.Forms.Label();
            this.label_Div1 = new System.Windows.Forms.Label();
            this.label_Mul2 = new System.Windows.Forms.Label();
            this.label_Mul1 = new System.Windows.Forms.Label();
            this.label_Sub2 = new System.Windows.Forms.Label();
            this.label_Sub1 = new System.Windows.Forms.Label();
            this.label_Sum2 = new System.Windows.Forms.Label();
            this.textBox_Sum1 = new System.Windows.Forms.TextBox();
            this.textBox_Sum2 = new System.Windows.Forms.TextBox();
            this.textBox_Sum3 = new System.Windows.Forms.TextBox();
            this.textBox_Sub2 = new System.Windows.Forms.TextBox();
            this.textBox_Sub3 = new System.Windows.Forms.TextBox();
            this.textBox_Mul1 = new System.Windows.Forms.TextBox();
            this.textBox_Mul2 = new System.Windows.Forms.TextBox();
            this.textBox_Mul3 = new System.Windows.Forms.TextBox();
            this.textBox_Div1 = new System.Windows.Forms.TextBox();
            this.textBox_Div2 = new System.Windows.Forms.TextBox();
            this.textBox_Div3 = new System.Windows.Forms.TextBox();
            this.button_Sum = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_Mul = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.label_Sum1 = new System.Windows.Forms.Label();
            this.textBox_Sub1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Controls.Add(this.label_Div2, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.label_Div1, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label_Mul2, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.label_Mul1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.label_Sub2, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.label_Sub1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label_Sum2, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sum1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sum2, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sum3, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sub2, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sub3, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.textBox_Mul1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox_Mul2, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox_Mul3, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox_Div1, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBox_Div2, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.textBox_Div3, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.button_Sum, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.button_Sub, 6, 1);
            this.tableLayoutPanel.Controls.Add(this.button_Mul, 6, 2);
            this.tableLayoutPanel.Controls.Add(this.button_Div, 6, 3);
            this.tableLayoutPanel.Controls.Add(this.label_Sum1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_Sub1, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00001F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(434, 411);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label_Div2
            // 
            this.label_Div2.AutoSize = true;
            this.label_Div2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Div2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Div2.Location = new System.Drawing.Point(210, 306);
            this.label_Div2.Name = "label_Div2";
            this.label_Div2.Size = new System.Drawing.Size(63, 105);
            this.label_Div2.TabIndex = 24;
            this.label_Div2.Text = "=";
            this.label_Div2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Div1
            // 
            this.label_Div1.AutoSize = true;
            this.label_Div1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Div1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Div1.Location = new System.Drawing.Point(72, 306);
            this.label_Div1.Name = "label_Div1";
            this.label_Div1.Size = new System.Drawing.Size(63, 105);
            this.label_Div1.TabIndex = 23;
            this.label_Div1.Text = "/";
            this.label_Div1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Mul2
            // 
            this.label_Mul2.AutoSize = true;
            this.label_Mul2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mul2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Mul2.Location = new System.Drawing.Point(210, 204);
            this.label_Mul2.Name = "label_Mul2";
            this.label_Mul2.Size = new System.Drawing.Size(63, 102);
            this.label_Mul2.TabIndex = 22;
            this.label_Mul2.Text = "=";
            this.label_Mul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Mul1
            // 
            this.label_Mul1.AutoSize = true;
            this.label_Mul1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mul1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Mul1.Location = new System.Drawing.Point(72, 204);
            this.label_Mul1.Name = "label_Mul1";
            this.label_Mul1.Size = new System.Drawing.Size(63, 102);
            this.label_Mul1.TabIndex = 21;
            this.label_Mul1.Text = "X";
            this.label_Mul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Sub2
            // 
            this.label_Sub2.AutoSize = true;
            this.label_Sub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Sub2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sub2.Location = new System.Drawing.Point(210, 102);
            this.label_Sub2.Name = "label_Sub2";
            this.label_Sub2.Size = new System.Drawing.Size(63, 102);
            this.label_Sub2.TabIndex = 20;
            this.label_Sub2.Text = "=";
            this.label_Sub2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Sub1
            // 
            this.label_Sub1.AutoSize = true;
            this.label_Sub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Sub1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sub1.Location = new System.Drawing.Point(72, 102);
            this.label_Sub1.Name = "label_Sub1";
            this.label_Sub1.Size = new System.Drawing.Size(63, 102);
            this.label_Sub1.TabIndex = 19;
            this.label_Sub1.Text = "-";
            this.label_Sub1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Sum2
            // 
            this.label_Sum2.AutoSize = true;
            this.label_Sum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Sum2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sum2.Location = new System.Drawing.Point(210, 0);
            this.label_Sum2.Name = "label_Sum2";
            this.label_Sum2.Size = new System.Drawing.Size(63, 102);
            this.label_Sum2.TabIndex = 18;
            this.label_Sum2.Text = "=";
            this.label_Sum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Sum1
            // 
            this.textBox_Sum1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sum1.Location = new System.Drawing.Point(3, 30);
            this.textBox_Sum1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sum1.Name = "textBox_Sum1";
            this.textBox_Sum1.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sum1.TabIndex = 1;
            // 
            // textBox_Sum2
            // 
            this.textBox_Sum2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sum2.Location = new System.Drawing.Point(141, 30);
            this.textBox_Sum2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sum2.Name = "textBox_Sum2";
            this.textBox_Sum2.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sum2.TabIndex = 2;
            // 
            // textBox_Sum3
            // 
            this.textBox_Sum3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sum3.Location = new System.Drawing.Point(279, 30);
            this.textBox_Sum3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sum3.Name = "textBox_Sum3";
            this.textBox_Sum3.ReadOnly = true;
            this.textBox_Sum3.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sum3.TabIndex = 3;
            // 
            // textBox_Sub2
            // 
            this.textBox_Sub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Sub2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sub2.Location = new System.Drawing.Point(141, 132);
            this.textBox_Sub2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sub2.Name = "textBox_Sub2";
            this.textBox_Sub2.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sub2.TabIndex = 5;
            // 
            // textBox_Sub3
            // 
            this.textBox_Sub3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Sub3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sub3.Location = new System.Drawing.Point(279, 132);
            this.textBox_Sub3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sub3.Name = "textBox_Sub3";
            this.textBox_Sub3.ReadOnly = true;
            this.textBox_Sub3.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sub3.TabIndex = 6;
            // 
            // textBox_Mul1
            // 
            this.textBox_Mul1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Mul1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Mul1.Location = new System.Drawing.Point(3, 234);
            this.textBox_Mul1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Mul1.Name = "textBox_Mul1";
            this.textBox_Mul1.Size = new System.Drawing.Size(63, 44);
            this.textBox_Mul1.TabIndex = 7;
            // 
            // textBox_Mul2
            // 
            this.textBox_Mul2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Mul2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Mul2.Location = new System.Drawing.Point(141, 234);
            this.textBox_Mul2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Mul2.Name = "textBox_Mul2";
            this.textBox_Mul2.Size = new System.Drawing.Size(63, 44);
            this.textBox_Mul2.TabIndex = 8;
            // 
            // textBox_Mul3
            // 
            this.textBox_Mul3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Mul3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Mul3.Location = new System.Drawing.Point(279, 234);
            this.textBox_Mul3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Mul3.Name = "textBox_Mul3";
            this.textBox_Mul3.ReadOnly = true;
            this.textBox_Mul3.Size = new System.Drawing.Size(63, 44);
            this.textBox_Mul3.TabIndex = 9;
            // 
            // textBox_Div1
            // 
            this.textBox_Div1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Div1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Div1.Location = new System.Drawing.Point(3, 336);
            this.textBox_Div1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Div1.Name = "textBox_Div1";
            this.textBox_Div1.Size = new System.Drawing.Size(63, 44);
            this.textBox_Div1.TabIndex = 10;
            // 
            // textBox_Div2
            // 
            this.textBox_Div2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Div2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Div2.Location = new System.Drawing.Point(141, 336);
            this.textBox_Div2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Div2.Name = "textBox_Div2";
            this.textBox_Div2.Size = new System.Drawing.Size(63, 44);
            this.textBox_Div2.TabIndex = 11;
            // 
            // textBox_Div3
            // 
            this.textBox_Div3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Div3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Div3.Location = new System.Drawing.Point(279, 336);
            this.textBox_Div3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Div3.Name = "textBox_Div3";
            this.textBox_Div3.ReadOnly = true;
            this.textBox_Div3.Size = new System.Drawing.Size(63, 44);
            this.textBox_Div3.TabIndex = 12;
            // 
            // button_Sum
            // 
            this.button_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Sum.Location = new System.Drawing.Point(368, 29);
            this.button_Sum.Name = "button_Sum";
            this.button_Sum.Size = new System.Drawing.Size(63, 44);
            this.button_Sum.TabIndex = 13;
            this.button_Sum.Text = "실행";
            this.button_Sum.UseVisualStyleBackColor = true;
            this.button_Sum.Click += new System.EventHandler(this.button_Sum_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Sub.Location = new System.Drawing.Point(368, 131);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(63, 44);
            this.button_Sub.TabIndex = 14;
            this.button_Sub.Text = "실행";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // button_Mul
            // 
            this.button_Mul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Mul.Location = new System.Drawing.Point(368, 233);
            this.button_Mul.Name = "button_Mul";
            this.button_Mul.Size = new System.Drawing.Size(63, 44);
            this.button_Mul.TabIndex = 15;
            this.button_Mul.Text = "실행";
            this.button_Mul.UseVisualStyleBackColor = true;
            this.button_Mul.Click += new System.EventHandler(this.button_Mul_Click);
            // 
            // button_Div
            // 
            this.button_Div.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Div.Location = new System.Drawing.Point(368, 336);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(63, 44);
            this.button_Div.TabIndex = 16;
            this.button_Div.Text = "실행";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.button_Div_Click);
            // 
            // label_Sum1
            // 
            this.label_Sum1.AutoSize = true;
            this.label_Sum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Sum1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sum1.Location = new System.Drawing.Point(72, 0);
            this.label_Sum1.Name = "label_Sum1";
            this.label_Sum1.Size = new System.Drawing.Size(63, 102);
            this.label_Sum1.TabIndex = 17;
            this.label_Sum1.Text = "+";
            this.label_Sum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Sub1
            // 
            this.textBox_Sub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Sub1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sub1.Location = new System.Drawing.Point(3, 132);
            this.textBox_Sub1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_Sub1.Name = "textBox_Sub1";
            this.textBox_Sub1.Size = new System.Drawing.Size(63, 44);
            this.textBox_Sub1.TabIndex = 4;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form_Main";
            this.Text = "P Invoke Test";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textBox_Sum1;
        private System.Windows.Forms.TextBox textBox_Sum3;
        private System.Windows.Forms.TextBox textBox_Sub2;
        private System.Windows.Forms.TextBox textBox_Sub3;
        private System.Windows.Forms.TextBox textBox_Mul1;
        private System.Windows.Forms.TextBox textBox_Mul2;
        private System.Windows.Forms.TextBox textBox_Mul3;
        private System.Windows.Forms.TextBox textBox_Div1;
        private System.Windows.Forms.TextBox textBox_Div2;
        private System.Windows.Forms.TextBox textBox_Div3;
        private System.Windows.Forms.Button button_Sum;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_Mul;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Label label_Div2;
        private System.Windows.Forms.Label label_Div1;
        private System.Windows.Forms.Label label_Mul2;
        private System.Windows.Forms.Label label_Mul1;
        private System.Windows.Forms.Label label_Sub2;
        private System.Windows.Forms.Label label_Sub1;
        private System.Windows.Forms.Label label_Sum2;
        private System.Windows.Forms.Label label_Sum1;
        private System.Windows.Forms.TextBox textBox_Sum2;
        private System.Windows.Forms.TextBox textBox_Sub1;
    }
}

