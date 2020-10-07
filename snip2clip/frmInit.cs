using System;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace snip2clip
{
    public partial class frmInit : Form
    {
        public static string imgpath;
        public bool upload = false;
        public frmInit()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            upload = true;
            OpenFileDialog img_loc = new OpenFileDialog
            {
                InitialDirectory = "c:\\Users\\%USERPROFILE%\\Photos\\",
                Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG; *.TIFF; *.JFIF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF; *.JFIF"
            };
            if (img_loc.ShowDialog() == DialogResult.OK)
            {
                imgpath = img_loc.FileName;
                Hide();
                frmResult frmres = new frmResult(imgpath);
                frmres.Show();

            }
        }

        private void btnSnip_Click(object sender, EventArgs e)
        {
            Hide();
            Thread.Sleep(250);
            try
            {
                Bitmap captureBmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,
                    PixelFormat.Format32bppArgb);
                Rectangle captureRect = Screen.PrimaryScreen.Bounds;
                Graphics captureGfx = Graphics.FromImage(captureBmp);
                captureGfx.CopyFromScreen(captureRect.Left, captureRect.Top, 0, 0, captureRect.Size);
                string tempPath = Environment.GetEnvironmentVariable("TEMP") + "\\snip2clip";
                try {
                    if (!Directory.Exists(tempPath))
                    {
                        Directory.CreateDirectory(tempPath);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                captureBmp.Save(tempPath + "\\capture.png", ImageFormat.Png);
                imgpath = tempPath + "\\capture.png";
                frmFullScreen fs = new frmFullScreen();
                fs.Show();
            } catch (Exception exx)
            {
                Console.WriteLine(exx.ToString());
            }
        }
        
    }
}
