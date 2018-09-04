namespace ImageFast
{
    partial class ExploreGradients
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
            this.PictureMain = new System.Windows.Forms.PictureBox();
            this.LblCoords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureMain
            // 
            this.PictureMain.Location = new System.Drawing.Point(12, 12);
            this.PictureMain.Name = "PictureMain";
            this.PictureMain.Size = new System.Drawing.Size(525, 312);
            this.PictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMain.TabIndex = 0;
            this.PictureMain.TabStop = false;
            this.PictureMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureMain_MouseMove);
            // 
            // LblCoords
            // 
            this.LblCoords.AutoSize = true;
            this.LblCoords.Location = new System.Drawing.Point(13, 331);
            this.LblCoords.Name = "LblCoords";
            this.LblCoords.Size = new System.Drawing.Size(53, 13);
            this.LblCoords.TabIndex = 1;
            this.LblCoords.Text = "X: 0 | Y: 0";
            // 
            // ExploreGradients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 355);
            this.Controls.Add(this.LblCoords);
            this.Controls.Add(this.PictureMain);
            this.Name = "ExploreGradients";
            this.Text = "Explore gradients";
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureMain;
        private System.Windows.Forms.Label LblCoords;
    }
}