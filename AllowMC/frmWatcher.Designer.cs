namespace AllowMC
{
    partial class frmMCWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMCWatcher));
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.lblStopTime = new System.Windows.Forms.Label();
            this.dtStopTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxMC = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.svcMgr = new System.ServiceProcess.ServiceController();
            this.groupBoxTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.lblTimer);
            this.groupBoxTimer.Controls.Add(this.lblTimeRemain);
            this.groupBoxTimer.Controls.Add(this.lblStopTime);
            this.groupBoxTimer.Controls.Add(this.dtStopTime);
            this.groupBoxTimer.Controls.Add(this.pictureBoxMC);
            this.groupBoxTimer.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(380, 144);
            this.groupBoxTimer.TabIndex = 0;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Set Timer";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(29, 89);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(202, 39);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "000.00 mins";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Location = new System.Drawing.Point(15, 72);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(83, 13);
            this.lblTimeRemain.TabIndex = 3;
            this.lblTimeRemain.Text = "Time Remaining";
            // 
            // lblStopTime
            // 
            this.lblStopTime.AutoSize = true;
            this.lblStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopTime.Location = new System.Drawing.Point(15, 33);
            this.lblStopTime.Name = "lblStopTime";
            this.lblStopTime.Size = new System.Drawing.Size(55, 13);
            this.lblStopTime.TabIndex = 2;
            this.lblStopTime.Text = "Stop Time";
            // 
            // dtStopTime
            // 
            this.dtStopTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStopTime.Location = new System.Drawing.Point(76, 29);
            this.dtStopTime.MinDate = new System.DateTime(2016, 1, 11, 0, 0, 0, 0);
            this.dtStopTime.Name = "dtStopTime";
            this.dtStopTime.Size = new System.Drawing.Size(153, 20);
            this.dtStopTime.TabIndex = 1;
            // 
            // pictureBoxMC
            // 
            this.pictureBoxMC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMC.Image")));
            this.pictureBoxMC.Location = new System.Drawing.Point(248, 10);
            this.pictureBoxMC.Name = "pictureBoxMC";
            this.pictureBoxMC.Size = new System.Drawing.Size(126, 128);
            this.pictureBoxMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMC.TabIndex = 0;
            this.pictureBoxMC.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(42, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(247, 173);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 1000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // svcMgr
            // 
            this.svcMgr.ServiceName = "AppWatcher";
            // 
            // frmMCWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 214);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMCWatcher";
            this.ShowInTaskbar = false;
            this.Text = "Minecraft Watcher";
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.PictureBox pictureBoxMC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DateTimePicker dtStopTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Label lblStopTime;
        private System.Windows.Forms.Timer timerPlay;
        private System.ServiceProcess.ServiceController svcMgr;
    }
}

