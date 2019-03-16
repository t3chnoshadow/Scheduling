namespace Sceduling
{
    partial class RoundRobbin
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblQuanta = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblThreadSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 764);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(1500, 37);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(9, 68);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(193, 17);
            this.lblThreads.TabIndex = 1;
            this.lblThreads.Text = "Enter the amount of threads :";
            // 
            // lblQuanta
            // 
            this.lblQuanta.AutoSize = true;
            this.lblQuanta.Location = new System.Drawing.Point(9, 9);
            this.lblQuanta.Name = "lblQuanta";
            this.lblQuanta.Size = new System.Drawing.Size(100, 17);
            this.lblQuanta.TabIndex = 3;
            this.lblQuanta.Text = "Size of thread:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(135, 9);
            this.trackBar1.Maximum = 1024;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1215, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(229, 63);
            this.numUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 22);
            this.numUpDown.TabIndex = 5;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThreadSize
            // 
            this.lblThreadSize.AutoSize = true;
            this.lblThreadSize.Location = new System.Drawing.Point(1356, 9);
            this.lblThreadSize.Name = "lblThreadSize";
            this.lblThreadSize.Size = new System.Drawing.Size(16, 17);
            this.lblThreadSize.TabIndex = 6;
            this.lblThreadSize.Text = "0";
            // 
            // RoundRobbin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 813);
            this.Controls.Add(this.lblThreadSize);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblQuanta);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.btnRun);
            this.Name = "RoundRobbin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round Robbin";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label lblQuanta;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label lblThreadSize;
    }
}