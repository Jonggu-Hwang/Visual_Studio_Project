using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //UI_imageBox1.MouseWheel += MouseWheelEvent;
            //UI_imageBox1.MouseEnter += MouseEnter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            if (button1.BackColor == Color.Black)
            {
                button1.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        //private void MouseWheelEvent(object sender, MouseEventArgs e)
        //{
        //    var pictureBox = sender as PictureBox;

        //    if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta > 0)
        //    {
        //        double ZOOM_FACTOR = 1.1;
        //        int MIN_MAX = 5;

        //        if ((UI_imageBox1.Width < (MIN_MAX * this.Width)) &&
        //            (UI_imageBox1.Height < (MIN_MAX * this.Height)))
        //        {
        //            UI_imageBox1.Width = Convert.ToInt32(UI_imageBox1.Width * ZOOM_FACTOR);
        //            UI_imageBox1.Height = Convert.ToInt32(UI_imageBox1.Height * ZOOM_FACTOR);
        //            //UI_imageBox1.Top = (int)(e.Y - ZOOM_FACTOR * (e.Y - UI_imageBox1.Top));
        //            //UI_imageBox1.Left = (int)(e.X - ZOOM_FACTOR * (e.X - UI_imageBox1.Left));
        //        }
        //    }
        //    else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta < 0)
        //    {
        //        double ZOOM_FACTOR = 1.1;
        //        int MIN_MAX = 5;

        //        if ((UI_imageBox1.Width > (this.Width / MIN_MAX)) &&
        //            (UI_imageBox1.Height > (this.Height / MIN_MAX)))
        //        {
        //            UI_imageBox1.Width = Convert.ToInt32(UI_imageBox1.Width / ZOOM_FACTOR);
        //            UI_imageBox1.Height = Convert.ToInt32(UI_imageBox1.Height / ZOOM_FACTOR);
        //            //UI_imageBox1.Top = (int)(e.Y - ZOOM_FACTOR * (e.Y - UI_imageBox1.Top));
        //            //UI_imageBox1.Left = (int)(e.X - ZOOM_FACTOR * (e.X - UI_imageBox1.Left));
        //        }
        //    }
        //    UI_imageBox1.Invalidate();
        //}
        //private void MouseEnter(object sender, EventArgs e)
        //{
        //    if (UI_imageBox1.Focused == false)
        //    {
        //        UI_imageBox1.Focus();
        //    }
        //}
    }
}
