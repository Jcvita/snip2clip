namespace snip2clip
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.picSnip = new System.Windows.Forms.PictureBox();
            this.txtOcr = new System.Windows.Forms.TextBox();
            this.lblOcr = new System.Windows.Forms.Label();
            this.btnCpyTxt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReDo = new System.Windows.Forms.Button();
            this.btnCpyImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSnip)).BeginInit();
            this.SuspendLayout();
            // 
            // picSnip
            // 
            this.picSnip.Location = new System.Drawing.Point(12, 158);
            this.picSnip.Name = "picSnip";
            this.picSnip.Size = new System.Drawing.Size(100, 50);
            this.picSnip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSnip.TabIndex = 0;
            this.picSnip.TabStop = false;
            // 
            // txtOcr
            // 
            this.txtOcr.Location = new System.Drawing.Point(145, 12);
            this.txtOcr.Multiline = true;
            this.txtOcr.Name = "txtOcr";
            this.txtOcr.Size = new System.Drawing.Size(280, 125);
            this.txtOcr.TabIndex = 1;
            // 
            // lblOcr
            // 
            this.lblOcr.AutoSize = true;
            this.lblOcr.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcr.Location = new System.Drawing.Point(8, 12);
            this.lblOcr.Name = "lblOcr";
            this.lblOcr.Size = new System.Drawing.Size(131, 19);
            this.lblOcr.TabIndex = 2;
            this.lblOcr.Text = "Detected Text:";
            // 
            // btnCpyTxt
            // 
            this.btnCpyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpyTxt.Location = new System.Drawing.Point(12, 34);
            this.btnCpyTxt.Name = "btnCpyTxt";
            this.btnCpyTxt.Size = new System.Drawing.Size(127, 103);
            this.btnCpyTxt.TabIndex = 3;
            this.btnCpyTxt.Text = "📋Aa";
            this.btnCpyTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpyTxt.UseVisualStyleBackColor = true;
            this.btnCpyTxt.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(431, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 103);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "💾";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReDo
            // 
            this.btnReDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReDo.Location = new System.Drawing.Point(539, 23);
            this.btnReDo.Name = "btnReDo";
            this.btnReDo.Size = new System.Drawing.Size(102, 103);
            this.btnReDo.TabIndex = 5;
            this.btnReDo.Text = "🔁";
            this.btnReDo.UseVisualStyleBackColor = true;
            this.btnReDo.Click += new System.EventHandler(this.btnReDo_Click);
            // 
            // btnCpyImg
            // 
            this.btnCpyImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpyImg.Location = new System.Drawing.Point(647, 23);
            this.btnCpyImg.Name = "btnCpyImg";
            this.btnCpyImg.Size = new System.Drawing.Size(102, 103);
            this.btnCpyImg.TabIndex = 6;
            this.btnCpyImg.Text = "📋📷";
            this.btnCpyImg.UseVisualStyleBackColor = true;
            this.btnCpyImg.Click += new System.EventHandler(this.btnCpyImg_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCpyImg);
            this.Controls.Add(this.btnReDo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCpyTxt);
            this.Controls.Add(this.lblOcr);
            this.Controls.Add(this.txtOcr);
            this.Controls.Add(this.picSnip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResult";
            this.Text = "Like ya cut, G";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmResult_FormClosed);
            this.Load += new System.EventHandler(this.frmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSnip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSnip;
        private System.Windows.Forms.TextBox txtOcr;
        private System.Windows.Forms.Label lblOcr;
        private System.Windows.Forms.Button btnCpyTxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReDo;
        private System.Windows.Forms.Button btnCpyImg;
    }
}