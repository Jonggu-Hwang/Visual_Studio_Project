using System;
using System.Windows.Forms;
using TM_UI;

namespace TM_Parameter
{
    public partial class Form_Parameter : Form
    {
        public double single_Thr;
        public int multiple_Count;
        Form_Main mainForm;

        public Form_Parameter(Form_Main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void ui_button_Para_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ui_button_Para_OK_Click(object sender, EventArgs e)
        {
            if (ui_radioButton_Single.Checked == true)
            {
                if (ui_textBox_Single_Thr.Text == "" || double.Parse(ui_textBox_Single_Thr.Text) > 1.0f)
                {
                    MessageBox.Show("Threshold는 0~1의 숫자만 입력할 수 있습니다.", "Error");
                    ui_textBox_Single_Thr.Undo();
                }
                else
                {
                    single_Thr = double.Parse(ui_textBox_Single_Thr.Text);

                    TemplateMatching.Properties.Settings.Default.radioSingle = ui_radioButton_Single.Checked;
                    TemplateMatching.Properties.Settings.Default.radioMultiple = ui_radioButton_Multiple.Checked;
                    TemplateMatching.Properties.Settings.Default.singleThr = ui_textBox_Single_Thr.Text;

                    this.Close();
                }

            }
            else if (ui_radioButton_Multiple.Checked == true)
            {

                if (ui_textBox_Multiple_Count.Text == "" || int.Parse(ui_textBox_Multiple_Count.Text) > 20 || int.Parse(ui_textBox_Multiple_Count.Text) == 0)
                {
                    MessageBox.Show("Count는 1~20의 숫자만 입력할 수 있습니다.", "Error");
                    ui_textBox_Multiple_Count.Undo();
                    return;
                }

                if (ui_textBox_Multiple_Count.Text == "" || int.Parse(ui_textBox_Multiple_Count.Text) > 20 || int.Parse(ui_textBox_Multiple_Count.Text) == 0)
                {
                    MessageBox.Show("Count는 1~20의 숫자만 입력할 수 있습니다.", "Error");
                    ui_textBox_Multiple_Count.Undo();
                    return;
                }

                multiple_Count = int.Parse(ui_textBox_Multiple_Count.Text);

                TemplateMatching.Properties.Settings.Default.radioSingle = ui_radioButton_Single.Checked;
                TemplateMatching.Properties.Settings.Default.radioMultiple = ui_radioButton_Multiple.Checked;
                TemplateMatching.Properties.Settings.Default.multipleCount = ui_textBox_Multiple_Count.Text;
                this.Close();
            }
        }

        private void ui_radioButton_Multiple_CheckedChanged(object sender, EventArgs e)
        {
            ui_panel_Multiple.Visible = true;
        }

        private void ui_radioButton_Single_CheckedChanged(object sender, EventArgs e)
        {
            ui_panel_Multiple.Visible = false;
        }
        private void ui_textBox_Single_Thr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void ui_textBox_Multiple_Thr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void ui_textBox_Multiple_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Form_Parameter_Load(object sender, EventArgs e)
        {
            ui_radioButton_Single.Checked = TemplateMatching.Properties.Settings.Default.radioSingle;
            ui_radioButton_Multiple.Checked = TemplateMatching.Properties.Settings.Default.radioMultiple;
            ui_textBox_Single_Thr.Text = TemplateMatching.Properties.Settings.Default.singleThr;
            ui_textBox_Multiple_Count.Text = TemplateMatching.Properties.Settings.Default.multipleCount;
        }
    }
}
