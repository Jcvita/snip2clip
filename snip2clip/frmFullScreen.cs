using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Tesseract;

namespace snip2clip
{
    public partial class frmFullScreen : Form
    {
        private bool hasStart = false;
        private bool hasEnd = false;
        private Point start = new Point();
        private Point end = new Point();
       
        public frmFullScreen()
        {
            InitializeComponent();
        }

        private void frmFullScreen_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            picScreenShot.Image = Image.FromFile(frmInit.imgpath);
            Controls.Add(picScreenShot);
        }

        private void picScreenShot_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            hasStart = true;
            hasEnd = false;
        }

        private void picScreenShot_MouseUp(object sender, MouseEventArgs e)
        {
            if (hasStart)
            {
                end = e.Location;
                hasEnd = true;
            }

        }

        private void picScreenShot_MouseMove(object sender, MouseEventArgs e)
        {
            if (hasStart && !hasEnd)
            {
                end = e.Location;
                Refresh();
            }
        } 

        
        private void frmFullScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Rectangle makeRect()
        {
            return new Rectangle
            {
                X = Math.Min(start.X, end.X),
                Y = Math.Min(start.Y, end.Y),
                Width = Math.Abs(end.X - start.X),
                Height = Math.Abs(end.Y - start.Y)
            };
        }

        private void picScreenShot_Paint(object sender, PaintEventArgs e)
        {
            if (hasStart)
            {

                e.Graphics.DrawString("ESC - Cancel\nSPACE - Quick OCR to clipboard\nAnything else - Save", DefaultFont, Brushes.Red,
                    makeRect().Left - 2, makeRect().Top - DefaultFont.Height*3);
                e.Graphics.DrawRectangle(Pens.Red, makeRect());
            }

        }

        private void frmFullScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (hasStart && hasEnd)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    //maybe return to menu idk up to you
                    Application.Exit();
                }
                else
                {
                    Bitmap src = Image.FromFile(frmInit.imgpath) as Bitmap;
                    Bitmap target = new Bitmap(makeRect().Width, makeRect().Height);
                    using (Graphics g = Graphics.FromImage(target))
                    {
                        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), makeRect(), GraphicsUnit.Pixel);
                    }
                    string tempPath = Environment.GetEnvironmentVariable("TEMP") + "\\snip2clip";
                    target.Save(tempPath + "\\crop.png", System.Drawing.Imaging.ImageFormat.Png);
                    frmResult res = new frmResult();
                    if (e.KeyCode == Keys.Space)
                    {
                        Clipboard.SetText(res.getOCR());
                        Application.Exit();
                    }
                    Hide();
                    res.Show();
                }
            }
        }

    }
}
