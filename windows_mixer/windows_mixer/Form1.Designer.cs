namespace windows_mixer
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.volumeMeter2 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter3 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter4 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter5 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter6 = new NAudio.Gui.VolumeMeter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.Location = new System.Drawing.Point(65, 191);
            this.volumeMeter1.MaxDb = 80F;
            this.volumeMeter1.MinDb = 0F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter1.TabIndex = 0;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // volumeMeter2
            // 
            this.volumeMeter2.Amplitude = 0F;
            this.volumeMeter2.Location = new System.Drawing.Point(173, 191);
            this.volumeMeter2.MaxDb = 80F;
            this.volumeMeter2.MinDb = 0F;
            this.volumeMeter2.Name = "volumeMeter2";
            this.volumeMeter2.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter2.TabIndex = 1;
            this.volumeMeter2.Text = "volumeMeter2";
            // 
            // volumeMeter3
            // 
            this.volumeMeter3.Amplitude = 0F;
            this.volumeMeter3.Location = new System.Drawing.Point(284, 191);
            this.volumeMeter3.MaxDb = 80F;
            this.volumeMeter3.MinDb = 0F;
            this.volumeMeter3.Name = "volumeMeter3";
            this.volumeMeter3.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter3.TabIndex = 2;
            this.volumeMeter3.Text = "volumeMeter3";
            // 
            // volumeMeter4
            // 
            this.volumeMeter4.Amplitude = 0F;
            this.volumeMeter4.Location = new System.Drawing.Point(391, 191);
            this.volumeMeter4.MaxDb = 80F;
            this.volumeMeter4.MinDb = 0F;
            this.volumeMeter4.Name = "volumeMeter4";
            this.volumeMeter4.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter4.TabIndex = 3;
            this.volumeMeter4.Text = "volumeMeter4";
            // 
            // volumeMeter5
            // 
            this.volumeMeter5.Amplitude = 0F;
            this.volumeMeter5.Location = new System.Drawing.Point(496, 191);
            this.volumeMeter5.MaxDb = 80F;
            this.volumeMeter5.MinDb = 0F;
            this.volumeMeter5.Name = "volumeMeter5";
            this.volumeMeter5.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter5.TabIndex = 4;
            this.volumeMeter5.Text = "volumeMeter5";
            // 
            // volumeMeter6
            // 
            this.volumeMeter6.Amplitude = 0F;
            this.volumeMeter6.Location = new System.Drawing.Point(610, 191);
            this.volumeMeter6.MaxDb = 80F;
            this.volumeMeter6.MinDb = 0F;
            this.volumeMeter6.Name = "volumeMeter6";
            this.volumeMeter6.Size = new System.Drawing.Size(27, 233);
            this.volumeMeter6.TabIndex = 5;
            this.volumeMeter6.Text = "volumeMeter6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeMeter6);
            this.Controls.Add(this.volumeMeter5);
            this.Controls.Add(this.volumeMeter4);
            this.Controls.Add(this.volumeMeter3);
            this.Controls.Add(this.volumeMeter2);
            this.Controls.Add(this.volumeMeter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NAudio.Gui.VolumeMeter volumeMeter2;
        private NAudio.Gui.VolumeMeter volumeMeter3;
        private NAudio.Gui.VolumeMeter volumeMeter4;
        private NAudio.Gui.VolumeMeter volumeMeter5;
        private NAudio.Gui.VolumeMeter volumeMeter6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

