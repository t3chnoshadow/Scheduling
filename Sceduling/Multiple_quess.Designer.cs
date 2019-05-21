namespace Sceduling
{
    partial class Multiple_quess
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
            this.components = new System.ComponentModel.Container();
            this.lblThreadSize = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblQuanta = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQue = new System.Windows.Forms.Label();
            this.lblprio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThreadSize
            // 
            this.lblThreadSize.AutoSize = true;
            this.lblThreadSize.Location = new System.Drawing.Point(1019, 11);
            this.lblThreadSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThreadSize.Name = "lblThreadSize";
            this.lblThreadSize.Size = new System.Drawing.Size(13, 13);
            this.lblThreadSize.TabIndex = 13;
            this.lblThreadSize.Text = "0";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(174, 55);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(2);
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
            this.numUpDown.Size = new System.Drawing.Size(90, 20);
            this.numUpDown.TabIndex = 12;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(103, 11);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 1024;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(911, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // lblQuanta
            // 
            this.lblQuanta.AutoSize = true;
            this.lblQuanta.Location = new System.Drawing.Point(9, 11);
            this.lblQuanta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanta.Name = "lblQuanta";
            this.lblQuanta.Size = new System.Drawing.Size(78, 13);
            this.lblQuanta.TabIndex = 10;
            this.lblQuanta.Text = "Size of prosess";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(9, 59);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(144, 13);
            this.lblThreads.TabIndex = 9;
            this.lblThreads.Text = "Enter the amount of threads :";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(11, 662);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(1125, 30);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1123, 569);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threads being executed";
            // 
            // lblQue
            // 
            this.lblQue.AutoSize = true;
            this.lblQue.Location = new System.Drawing.Point(926, 62);
            this.lblQue.Name = "lblQue";
            this.lblQue.Size = new System.Drawing.Size(67, 13);
            this.lblQue.TabIndex = 15;
            this.lblQue.Text = "Current Que:";
            // 
            // lblprio
            // 
            this.lblprio.AutoSize = true;
            this.lblprio.Location = new System.Drawing.Point(823, 62);
            this.lblprio.Name = "lblprio";
            this.lblprio.Size = new System.Drawing.Size(77, 13);
            this.lblprio.TabIndex = 16;
            this.lblprio.Text = "Current priority:";
            // 
            // Multiple_quess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 797);
            this.Controls.Add(this.lblprio);
            this.Controls.Add(this.lblQue);
            this.Controls.Add(this.lblThreadSize);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblQuanta);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Name = "Multiple_quess";
            this.Text = "Multiple_quess";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreadSize;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblQuanta;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQue;
        private System.Windows.Forms.Label lblprio;
    }
}