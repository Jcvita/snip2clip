using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace snip2clip
{
    public partial class frmResult : Form
    {
        private static string tempPath = Environment.GetEnvironmentVariable("TEMP") + "\\snip2clip";
        private Bitmap clip = Image.FromFile(tempPath + "\\crop.png") as Bitmap;
        public frmResult()
        {
            InitializeComponent();
        }
        public frmResult(string imagePath)
        {
            clip = Image.FromFile(imagePath) as Bitmap;
            InitializeComponent();
        }

        public string getOCR()
        {
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndLstm);
            var page = ocr.Process(clip);
            return page.GetText();
        }
        private void frmResult_Load(object sender, EventArgs e)
        {
            txtOcr.Text = getOCR();
            picSnip.Image = clip;

        }

        private void frmResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOcr.Text);
        }

        private void btnReDo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCpyImg_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(clip);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.Filter = "JPeg Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|TIFF Image|*.tiff";
            saveimg.Title = "Save snip as";
            saveimg.ShowDialog();

            System.IO.FileStream fs = (System.IO.FileStream)saveimg.OpenFile();
            switch (saveimg.FilterIndex)
            {
                case 1:
                    clip.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case 2:
                    clip.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case 3:
                    clip.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case 4:
                    clip.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case 5:
                    clip.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
                    break;
            }
        }
    }
}
