namespace snip2clip
{
    partial class frmFullScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFullScreen));
            this.picScreenShot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreenShot
            // 
            this.picScreenShot.BackColor = System.Drawing.Color.White;
            this.picScreenShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScreenShot.Location = new System.Drawing.Point(0, 0);
            this.picScreenShot.Name = "picScreenShot";
            this.picScreenShot.Size = new System.Drawing.Size(800, 450);
            this.picScreenShot.TabIndex = 0;
            this.picScreenShot.TabStop = false;
            this.picScreenShot.Paint += new System.Windows.Forms.PaintEventHandler(this.picScreenShot_Paint);
            this.picScreenShot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picScreenShot_MouseDown);
            this.picScreenShot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picScreenShot_MouseMove);
            this.picScreenShot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picScreenShot_MouseUp);
            // 
            // frmFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picScreenShot);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFullScreen";
            this.Text = "frmFullScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFullScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmFullScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFullScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScreenShot;
    }
}