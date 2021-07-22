using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_App
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        void TransparetBackground(Control C)
        {   //Make label invisible
            C.Visible = false;
            C.Refresh();
            Application.DoEvents();
            //Make image of background behind label
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            //set background of label to created image
            C.BackgroundImage = bmp;
            //make label visable
            C.Visible = true;
        }
        //Use timer class
        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {//call transparent background for title label
            TransparetBackground(lblTitle);
            //set tmr as timer call
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //start the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {   //stop the time
            tmr.Stop();
            //display mainform
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            //get rid of this form
            this.Hide();
        }
    }
}
