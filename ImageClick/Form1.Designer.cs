namespace ImageClick
{
    partial class ImageStorage
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
            this.imagestorgae = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imagestorgae
            // 
            this.imagestorgae.Dock = System.Windows.Forms.DockStyle.Right;
            this.imagestorgae.Location = new System.Drawing.Point(187, 0);
            this.imagestorgae.Name = "imagestorgae";
            this.imagestorgae.Size = new System.Drawing.Size(613, 450);
            this.imagestorgae.TabIndex = 0;
            // 
            // ImageStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagestorgae);
            this.Name = "ImageStorage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagestorgae;
    }
}

