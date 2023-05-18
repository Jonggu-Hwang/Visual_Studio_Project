using System;
using System.Windows.Forms;
using System.Xml;
using TM_Main;

namespace TM_Parameter
{
    public partial class Form_Parameter : Form
    {
        #region 변수 선언

        public double single_Thr = 0;
        public int multiple_Count = 1;
        public string strLocalFolder = System.IO.Directory.GetCurrentDirectory();
        public string strXmlFile = "\\XmlSettings.xml";
        #endregion

        public Form_Parameter()
        {
            InitializeComponent();
        }

        private void Form_Parameter_Load(object sender, EventArgs e)
        {
            ui_radioButton_Single.Checked = TemplateMatching.Properties.Settings.Default.radioSingle;
            ui_radioButton_Multiple.Checked = TemplateMatching.Properties.Settings.Default.radioMultiple;
            ui_textBox_Single_Thr.Text = TemplateMatching.Properties.Settings.Default.singleThr;
            ui_textBox_Multiple_Count.Text = TemplateMatching.Properties.Settings.Default.multipleCount;
        }

        #region button

        private void ui_button_Para_Cancel_Click(object sender, EventArgs e)
        {
            single_Thr = double.Parse(TemplateMatching.Properties.Settings.Default.singleThr);
            multiple_Count = int.Parse(TemplateMatching.Properties.Settings.Default.multipleCount);

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
                    TemplateMatching.Properties.Settings.Default.multipleCount = ui_textBox_Multiple_Count.Text;

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
                TemplateMatching.Properties.Settings.Default.singleThr = ui_textBox_Single_Thr.Text;
                TemplateMatching.Properties.Settings.Default.multipleCount = ui_textBox_Multiple_Count.Text;
                this.Close();
            }
        }

        private void ui_button_XmlSave_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlSettings = new XmlDocument();
                XmlNode xmlPara = xmlSettings.CreateElement("Parameter");

                XmlNode xmlRadioButton = xmlSettings.CreateElement("RadioButton");
                XmlAttribute xmlRadioSingle = xmlSettings.CreateAttribute("radioButton_Single");
                XmlAttribute xmlRadioMultiple = xmlSettings.CreateAttribute("radioButton_Multiple");

                xmlRadioSingle.Value = ui_radioButton_Single.Checked.ToString();
                xmlRadioMultiple.Value = ui_radioButton_Multiple.Checked.ToString();

                xmlRadioButton.Attributes.Append(xmlRadioSingle);
                xmlRadioButton.Attributes.Append(xmlRadioMultiple);

                XmlNode xmlTextSingle = xmlSettings.CreateElement("Single_Threshold");
                xmlTextSingle.InnerText = ui_textBox_Single_Thr.Text;

                XmlNode xmlTextMultiple = xmlSettings.CreateElement("Multiple_Count");
                xmlTextMultiple.InnerText = ui_textBox_Multiple_Count.Text;

                xmlPara.AppendChild(xmlRadioButton);
                xmlPara.AppendChild(xmlTextSingle);
                xmlPara.AppendChild(xmlTextMultiple);

                xmlSettings.AppendChild(xmlPara);
                xmlSettings.Save(strLocalFolder + strXmlFile);

                MessageBox.Show("설정 저장이 완료되었습니다.", "Parameter Setup");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ui_button_XmlLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists(strLocalFolder + strXmlFile))
                {
                    MessageBox.Show("설정 파일이 존재하지 않습니다.", "Error");
                    return;
                }
                XmlDocument xmlSettings = new XmlDocument();
                xmlSettings.Load(strLocalFolder + strXmlFile);
                XmlNodeList xmlNodeList = xmlSettings.SelectNodes("/Parameter");

                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    ui_radioButton_Single.Checked = Convert.ToBoolean(xmlNode["RadioButton"].Attributes["radioButton_Single"].Value);
                    ui_radioButton_Multiple.Checked = Convert.ToBoolean(xmlNode["RadioButton"].Attributes["radioButton_Multiple"].Value);
                    ui_textBox_Single_Thr.Text = xmlNode["Single_Threshold"].InnerText;
                    ui_textBox_Multiple_Count.Text = xmlNode["Multiple_Count"].InnerText;
                }
                MessageBox.Show("설정 불러오기가 완료되었습니다.", "Parameter Setup");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region radioButton

        private void ui_radioButton_Multiple_CheckedChanged(object sender, EventArgs e)
        {
            ui_panel_Multiple.Visible = true;
        }

        private void ui_radioButton_Single_CheckedChanged(object sender, EventArgs e)
        {
            ui_panel_Multiple.Visible = false;
        }

        #endregion

        #region textBox

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

        #endregion
    }
}
