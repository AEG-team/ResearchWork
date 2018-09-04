namespace ImageFast
{
    partial class MainForm
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
            this.ImgInput = new System.Windows.Forms.PictureBox();
            this.ImgOutput = new System.Windows.Forms.PictureBox();
            this.GroupOptions = new System.Windows.Forms.GroupBox();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.ChcInverse = new System.Windows.Forms.CheckBox();
            this.ChcBlackWhite = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BtnResultToInput = new System.Windows.Forms.Button();
            this.BtnMakeFractal = new System.Windows.Forms.Button();
            this.ChcMedianFilter = new System.Windows.Forms.CheckBox();
            this.BtnDetectEdges = new System.Windows.Forms.Button();
            this.NumericTrashold = new System.Windows.Forms.NumericUpDown();
            this.BtnExplore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOutput)).BeginInit();
            this.GroupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTrashold)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgInput
            // 
            this.ImgInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgInput.Location = new System.Drawing.Point(12, 12);
            this.ImgInput.Name = "ImgInput";
            this.ImgInput.Size = new System.Drawing.Size(300, 200);
            this.ImgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgInput.TabIndex = 0;
            this.ImgInput.TabStop = false;
            this.ImgInput.Click += new System.EventHandler(this.ImgInput_Click);
            // 
            // ImgOutput
            // 
            this.ImgOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgOutput.Location = new System.Drawing.Point(472, 12);
            this.ImgOutput.Name = "ImgOutput";
            this.ImgOutput.Size = new System.Drawing.Size(300, 200);
            this.ImgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgOutput.TabIndex = 1;
            this.ImgOutput.TabStop = false;
            this.ImgOutput.Click += new System.EventHandler(this.ImgOutput_Click);
            // 
            // GroupOptions
            // 
            this.GroupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GroupOptions.Controls.Add(this.ChcMedianFilter);
            this.GroupOptions.Controls.Add(this.BtnMakeFractal);
            this.GroupOptions.Controls.Add(this.BtnResultToInput);
            this.GroupOptions.Controls.Add(this.BtnProcess);
            this.GroupOptions.Controls.Add(this.ChcInverse);
            this.GroupOptions.Controls.Add(this.ChcBlackWhite);
            this.GroupOptions.Location = new System.Drawing.Point(318, 12);
            this.GroupOptions.MaximumSize = new System.Drawing.Size(148, 200);
            this.GroupOptions.MinimumSize = new System.Drawing.Size(148, 200);
            this.GroupOptions.Name = "GroupOptions";
            this.GroupOptions.Size = new System.Drawing.Size(148, 200);
            this.GroupOptions.TabIndex = 2;
            this.GroupOptions.TabStop = false;
            this.GroupOptions.Text = "Options";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProcess.Location = new System.Drawing.Point(7, 171);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(135, 23);
            this.BtnProcess.TabIndex = 2;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // ChcInverse
            // 
            this.ChcInverse.AutoSize = true;
            this.ChcInverse.Location = new System.Drawing.Point(7, 44);
            this.ChcInverse.Name = "ChcInverse";
            this.ChcInverse.Size = new System.Drawing.Size(92, 17);
            this.ChcInverse.TabIndex = 1;
            this.ChcInverse.Text = "Inverse colors";
            this.ChcInverse.UseVisualStyleBackColor = true;
            // 
            // ChcBlackWhite
            // 
            this.ChcBlackWhite.AutoSize = true;
            this.ChcBlackWhite.Location = new System.Drawing.Point(7, 20);
            this.ChcBlackWhite.Name = "ChcBlackWhite";
            this.ChcBlackWhite.Size = new System.Drawing.Size(102, 17);
            this.ChcBlackWhite.TabIndex = 0;
            this.ChcBlackWhite.Text = "Black and white";
            this.ChcBlackWhite.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(638, 218);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(134, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // BtnResultToInput
            // 
            this.BtnResultToInput.Location = new System.Drawing.Point(7, 142);
            this.BtnResultToInput.Name = "BtnResultToInput";
            this.BtnResultToInput.Size = new System.Drawing.Size(135, 23);
            this.BtnResultToInput.TabIndex = 3;
            this.BtnResultToInput.Text = "Result to input";
            this.BtnResultToInput.UseVisualStyleBackColor = true;
            this.BtnResultToInput.Click += new System.EventHandler(this.BtnResultToInput_Click);
            // 
            // BtnMakeFractal
            // 
            this.BtnMakeFractal.Location = new System.Drawing.Point(7, 113);
            this.BtnMakeFractal.Name = "BtnMakeFractal";
            this.BtnMakeFractal.Size = new System.Drawing.Size(135, 23);
            this.BtnMakeFractal.TabIndex = 4;
            this.BtnMakeFractal.Text = "Make fractal";
            this.BtnMakeFractal.UseVisualStyleBackColor = true;
            this.BtnMakeFractal.Click += new System.EventHandler(this.BtnMakeFractal_Click);
            // 
            // ChcMedianFilter
            // 
            this.ChcMedianFilter.AutoSize = true;
            this.ChcMedianFilter.Location = new System.Drawing.Point(7, 68);
            this.ChcMedianFilter.Name = "ChcMedianFilter";
            this.ChcMedianFilter.Size = new System.Drawing.Size(83, 17);
            this.ChcMedianFilter.TabIndex = 5;
            this.ChcMedianFilter.Text = "Median filter";
            this.ChcMedianFilter.UseVisualStyleBackColor = true;
            // 
            // BtnDetectEdges
            // 
            this.BtnDetectEdges.Location = new System.Drawing.Point(102, 218);
            this.BtnDetectEdges.Name = "BtnDetectEdges";
            this.BtnDetectEdges.Size = new System.Drawing.Size(135, 23);
            this.BtnDetectEdges.TabIndex = 4;
            this.BtnDetectEdges.Text = "Detect edges";
            this.BtnDetectEdges.UseVisualStyleBackColor = true;
            this.BtnDetectEdges.Click += new System.EventHandler(this.BtnDetectEdges_Click);
            // 
            // NumericTrashold
            // 
            this.NumericTrashold.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericTrashold.Location = new System.Drawing.Point(12, 218);
            this.NumericTrashold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericTrashold.Name = "NumericTrashold";
            this.NumericTrashold.Size = new System.Drawing.Size(84, 20);
            this.NumericTrashold.TabIndex = 5;
            this.NumericTrashold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // BtnExplore
            // 
            this.BtnExplore.Location = new System.Drawing.Point(325, 218);
            this.BtnExplore.Name = "BtnExplore";
            this.BtnExplore.Size = new System.Drawing.Size(135, 23);
            this.BtnExplore.TabIndex = 6;
            this.BtnExplore.Text = "Explore";
            this.BtnExplore.UseVisualStyleBackColor = true;
            this.BtnExplore.Click += new System.EventHandler(this.BtnExplore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 251);
            this.Controls.Add(this.BtnExplore);
            this.Controls.Add(this.NumericTrashold);
            this.Controls.Add(this.BtnDetectEdges);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.GroupOptions);
            this.Controls.Add(this.ImgOutput);
            this.Controls.Add(this.ImgInput);
            this.Name = "MainForm";
            this.Text = "Image Fast";
            ((System.ComponentModel.ISupportInitialize)(this.ImgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOutput)).EndInit();
            this.GroupOptions.ResumeLayout(false);
            this.GroupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTrashold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgInput;
        private System.Windows.Forms.PictureBox ImgOutput;
        private System.Windows.Forms.GroupBox GroupOptions;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.CheckBox ChcInverse;
        private System.Windows.Forms.CheckBox ChcBlackWhite;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button BtnResultToInput;
        private System.Windows.Forms.Button BtnMakeFractal;
        private System.Windows.Forms.CheckBox ChcMedianFilter;
        private System.Windows.Forms.Button BtnDetectEdges;
        private System.Windows.Forms.NumericUpDown NumericTrashold;
        private System.Windows.Forms.Button BtnExplore;
    }
}

