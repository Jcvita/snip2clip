namespace snip2clip
{
    partial class frmInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInit));
            this.btnSnip = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblSnip = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSnip
            // 
            this.btnSnip.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnip.Location = new System.Drawing.Point(12, 43);
            this.btnSnip.Name = "btnSnip";
            this.btnSnip.Size = new System.Drawing.Size(185, 177);
            this.btnSnip.TabIndex = 0;
            this.btnSnip.Text = "✂️";
            this.btnSnip.UseVisualStyleBackColor = true;
            this.btnSnip.Click += new System.EventHandler(this.btnSnip_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(210, 43);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(185, 177);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "↑";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblSnip
            // 
            this.lblSnip.AutoSize = true;
            this.lblSnip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnip.Location = new System.Drawing.Point(59, 16);
            this.lblSnip.Name = "lblSnip";
            this.lblSnip.Size = new System.Drawing.Size(92, 24);
            this.lblSnip.TabIndex = 2;
            this.lblSnip.Text = "New Snip";
            // 
            // lblUpload
            // 
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(228, 16);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(144, 26);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload for OCR";
            // 
            // frmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 232);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblSnip);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSnip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 271);
            this.MinimumSize = new System.Drawing.Size(423, 271);
            this.Name = "frmInit";
            this.Text = "snip2clip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnip;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSnip;
        private System.Windows.Forms.Label lblUpload;
    }
}

