namespace WindowsFormsApplication1
{
    partial class PNG_Viewer
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
            this.ld1 = new System.Windows.Forms.Label();
            this.ld2 = new System.Windows.Forms.Label();
            this.lmonth = new System.Windows.Forms.Label();
            this.lh1 = new System.Windows.Forms.Label();
            this.lh2 = new System.Windows.Forms.Label();
            this.lm1 = new System.Windows.Forms.Label();
            this.lm2 = new System.Windows.Forms.Label();
            this.ls1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ld1
            // 
            this.ld1.AutoSize = true;
            this.ld1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ld1.Location = new System.Drawing.Point(12, 13);
            this.ld1.Name = "ld1";
            this.ld1.Size = new System.Drawing.Size(18, 19);
            this.ld1.TabIndex = 0;
            this.ld1.Text = "2";
            this.ld1.Click += new System.EventHandler(this.ld1_Click);
            // 
            // ld2
            // 
            this.ld2.AutoSize = true;
            this.ld2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ld2.Location = new System.Drawing.Point(33, 13);
            this.ld2.Name = "ld2";
            this.ld2.Size = new System.Drawing.Size(18, 19);
            this.ld2.TabIndex = 1;
            this.ld2.Text = "6";
            this.ld2.Click += new System.EventHandler(this.ld2_Click);
            // 
            // lmonth
            // 
            this.lmonth.AutoSize = true;
            this.lmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lmonth.Location = new System.Drawing.Point(57, 13);
            this.lmonth.Name = "lmonth";
            this.lmonth.Size = new System.Drawing.Size(49, 19);
            this.lmonth.TabIndex = 2;
            this.lmonth.Text = "Month";
            this.lmonth.Click += new System.EventHandler(this.lmonth_Click);
            // 
            // lh1
            // 
            this.lh1.AutoSize = true;
            this.lh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lh1.Location = new System.Drawing.Point(142, 13);
            this.lh1.Name = "lh1";
            this.lh1.Size = new System.Drawing.Size(18, 19);
            this.lh1.TabIndex = 3;
            this.lh1.Text = "1";
            this.lh1.Click += new System.EventHandler(this.lh1_Click);
            // 
            // lh2
            // 
            this.lh2.AutoSize = true;
            this.lh2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lh2.Location = new System.Drawing.Point(164, 13);
            this.lh2.Name = "lh2";
            this.lh2.Size = new System.Drawing.Size(18, 19);
            this.lh2.TabIndex = 4;
            this.lh2.Text = "2";
            this.lh2.Click += new System.EventHandler(this.lh2_Click);
            // 
            // lm1
            // 
            this.lm1.AutoSize = true;
            this.lm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lm1.Location = new System.Drawing.Point(197, 13);
            this.lm1.Name = "lm1";
            this.lm1.Size = new System.Drawing.Size(18, 19);
            this.lm1.TabIndex = 5;
            this.lm1.Text = "1";
            this.lm1.Click += new System.EventHandler(this.lm1_Click);
            // 
            // lm2
            // 
            this.lm2.AutoSize = true;
            this.lm2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lm2.Location = new System.Drawing.Point(219, 13);
            this.lm2.Name = "lm2";
            this.lm2.Size = new System.Drawing.Size(18, 19);
            this.lm2.TabIndex = 6;
            this.lm2.Text = "2";
            this.lm2.Click += new System.EventHandler(this.lm2_Click);
            // 
            // ls1
            // 
            this.ls1.AutoSize = true;
            this.ls1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ls1.Location = new System.Drawing.Point(252, 13);
            this.ls1.Name = "ls1";
            this.ls1.Size = new System.Drawing.Size(26, 19);
            this.ls1.TabIndex = 7;
            this.ls1.Text = "10";
            this.ls1.Click += new System.EventHandler(this.ls1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(12, 53);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(405, 56);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Console:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PNG_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ls1);
            this.Controls.Add(this.lm2);
            this.Controls.Add(this.lm1);
            this.Controls.Add(this.lh2);
            this.Controls.Add(this.lh1);
            this.Controls.Add(this.lmonth);
            this.Controls.Add(this.ld2);
            this.Controls.Add(this.ld1);
            this.Name = "PNG_Viewer";
            this.Text = "PNG_Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ld1;
        private System.Windows.Forms.Label ld2;
        private System.Windows.Forms.Label lmonth;
        private System.Windows.Forms.Label lh1;
        private System.Windows.Forms.Label lh2;
        private System.Windows.Forms.Label lm1;
        private System.Windows.Forms.Label lm2;
        private System.Windows.Forms.Label ls1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}