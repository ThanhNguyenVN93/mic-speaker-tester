namespace frm_sound_mic_test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.GroupBox grpMic;
        private System.Windows.Forms.Label lblMicDeviceCaption;
        private System.Windows.Forms.ComboBox cbMicDevice;
        private System.Windows.Forms.Button btnRefreshMic;
        private System.Windows.Forms.ProgressBar pbMicLevel;
        private System.Windows.Forms.Button btnTestMic;
        private System.Windows.Forms.CheckBox chkMicMonitor;

        private System.Windows.Forms.GroupBox grpSpeaker;
        private System.Windows.Forms.Label lblSpeakerDeviceCaption;
        private System.Windows.Forms.ComboBox cbSpeakerDevice;
        private System.Windows.Forms.Button btnRefreshSpeaker;
        private System.Windows.Forms.Label lblVolumeCaption;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Button btnTestSpeakerLeft;
        private System.Windows.Forms.Button btnTestSpeakerRight;
        private System.Windows.Forms.Button btnTestSpeakerBoth;

        private System.Windows.Forms.Label lblStatus;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpMic = new System.Windows.Forms.GroupBox();
            this.lblMicDeviceCaption = new System.Windows.Forms.Label();
            this.cbMicDevice = new System.Windows.Forms.ComboBox();
            this.btnRefreshMic = new System.Windows.Forms.Button();
            this.pbMicLevel = new System.Windows.Forms.ProgressBar();
            this.btnTestMic = new System.Windows.Forms.Button();
            this.chkMicMonitor = new System.Windows.Forms.CheckBox();
            this.grpSpeaker = new System.Windows.Forms.GroupBox();
            this.lblSpeakerDeviceCaption = new System.Windows.Forms.Label();
            this.cbSpeakerDevice = new System.Windows.Forms.ComboBox();
            this.btnRefreshSpeaker = new System.Windows.Forms.Button();
            this.lblVolumeCaption = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.btnTestSpeakerLeft = new System.Windows.Forms.Button();
            this.btnTestSpeakerRight = new System.Windows.Forms.Button();
            this.btnTestSpeakerBoth = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpMic.SuspendLayout();
            this.grpSpeaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMic
            // 
            this.grpMic.Controls.Add(this.lblMicDeviceCaption);
            this.grpMic.Controls.Add(this.cbMicDevice);
            this.grpMic.Controls.Add(this.btnRefreshMic);
            this.grpMic.Controls.Add(this.pbMicLevel);
            this.grpMic.Controls.Add(this.btnTestMic);
            this.grpMic.Controls.Add(this.chkMicMonitor);
            this.grpMic.Location = new System.Drawing.Point(12, 12);
            this.grpMic.Name = "grpMic";
            this.grpMic.Size = new System.Drawing.Size(596, 150);
            this.grpMic.TabIndex = 0;
            this.grpMic.TabStop = false;
            this.grpMic.Text = "Microphone";
            // 
            // lblMicDeviceCaption
            // 
            this.lblMicDeviceCaption.AutoSize = true;
            this.lblMicDeviceCaption.Location = new System.Drawing.Point(16, 28);
            this.lblMicDeviceCaption.Name = "lblMicDeviceCaption";
            this.lblMicDeviceCaption.Size = new System.Drawing.Size(101, 13);
            this.lblMicDeviceCaption.TabIndex = 0;
            this.lblMicDeviceCaption.Text = "Microphone device:";
            // 
            // cbMicDevice
            // 
            this.cbMicDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMicDevice.FormattingEnabled = true;
            this.cbMicDevice.Location = new System.Drawing.Point(130, 24);
            this.cbMicDevice.Name = "cbMicDevice";
            this.cbMicDevice.Size = new System.Drawing.Size(350, 21);
            this.cbMicDevice.TabIndex = 1;
            // 
            // btnRefreshMic
            // 
            this.btnRefreshMic.Location = new System.Drawing.Point(490, 23);
            this.btnRefreshMic.Name = "btnRefreshMic";
            this.btnRefreshMic.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshMic.TabIndex = 2;
            this.btnRefreshMic.Text = "Refresh";
            this.btnRefreshMic.UseVisualStyleBackColor = true;
            this.btnRefreshMic.Click += new System.EventHandler(this.btnRefreshMic_Click);
            // 
            // pbMicLevel
            // 
            this.pbMicLevel.Location = new System.Drawing.Point(16, 58);
            this.pbMicLevel.Name = "pbMicLevel";
            this.pbMicLevel.Size = new System.Drawing.Size(564, 20);
            this.pbMicLevel.TabIndex = 3;
            // 
            // btnTestMic
            // 
            this.btnTestMic.Location = new System.Drawing.Point(16, 90);
            this.btnTestMic.Name = "btnTestMic";
            this.btnTestMic.Size = new System.Drawing.Size(160, 32);
            this.btnTestMic.TabIndex = 4;
            this.btnTestMic.Text = "Start Mic Test";
            this.btnTestMic.UseVisualStyleBackColor = false;
            this.btnTestMic.Click += new System.EventHandler(this.btnTestMic_Click);
            // 
            // chkMicMonitor
            // 
            this.chkMicMonitor.AutoSize = true;
            this.chkMicMonitor.Enabled = false;
            this.chkMicMonitor.Location = new System.Drawing.Point(190, 98);
            this.chkMicMonitor.Name = "chkMicMonitor";
            this.chkMicMonitor.Size = new System.Drawing.Size(213, 17);
            this.chkMicMonitor.TabIndex = 5;
            this.chkMicMonitor.Text = "Monitor mic through speaker (loopback)";
            this.chkMicMonitor.UseVisualStyleBackColor = true;
            this.chkMicMonitor.CheckedChanged += new System.EventHandler(this.chkMicMonitor_CheckedChanged);
            // 
            // grpSpeaker
            // 
            this.grpSpeaker.Controls.Add(this.lblSpeakerDeviceCaption);
            this.grpSpeaker.Controls.Add(this.cbSpeakerDevice);
            this.grpSpeaker.Controls.Add(this.btnRefreshSpeaker);
            this.grpSpeaker.Controls.Add(this.lblVolumeCaption);
            this.grpSpeaker.Controls.Add(this.tbVolume);
            this.grpSpeaker.Controls.Add(this.lblVolumeValue);
            this.grpSpeaker.Controls.Add(this.btnTestSpeakerLeft);
            this.grpSpeaker.Controls.Add(this.btnTestSpeakerRight);
            this.grpSpeaker.Controls.Add(this.btnTestSpeakerBoth);
            this.grpSpeaker.Location = new System.Drawing.Point(12, 174);
            this.grpSpeaker.Name = "grpSpeaker";
            this.grpSpeaker.Size = new System.Drawing.Size(596, 170);
            this.grpSpeaker.TabIndex = 6;
            this.grpSpeaker.TabStop = false;
            this.grpSpeaker.Text = "Speaker";
            // 
            // lblSpeakerDeviceCaption
            // 
            this.lblSpeakerDeviceCaption.AutoSize = true;
            this.lblSpeakerDeviceCaption.Location = new System.Drawing.Point(16, 28);
            this.lblSpeakerDeviceCaption.Name = "lblSpeakerDeviceCaption";
            this.lblSpeakerDeviceCaption.Size = new System.Drawing.Size(85, 13);
            this.lblSpeakerDeviceCaption.TabIndex = 0;
            this.lblSpeakerDeviceCaption.Text = "Speaker device:";
            // 
            // cbSpeakerDevice
            // 
            this.cbSpeakerDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeakerDevice.FormattingEnabled = true;
            this.cbSpeakerDevice.Location = new System.Drawing.Point(130, 24);
            this.cbSpeakerDevice.Name = "cbSpeakerDevice";
            this.cbSpeakerDevice.Size = new System.Drawing.Size(350, 21);
            this.cbSpeakerDevice.TabIndex = 1;
            // 
            // btnRefreshSpeaker
            // 
            this.btnRefreshSpeaker.Location = new System.Drawing.Point(490, 23);
            this.btnRefreshSpeaker.Name = "btnRefreshSpeaker";
            this.btnRefreshSpeaker.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshSpeaker.TabIndex = 2;
            this.btnRefreshSpeaker.Text = "Refresh";
            this.btnRefreshSpeaker.UseVisualStyleBackColor = true;
            this.btnRefreshSpeaker.Click += new System.EventHandler(this.btnRefreshSpeaker_Click);
            // 
            // lblVolumeCaption
            // 
            this.lblVolumeCaption.AutoSize = true;
            this.lblVolumeCaption.Location = new System.Drawing.Point(16, 64);
            this.lblVolumeCaption.Name = "lblVolumeCaption";
            this.lblVolumeCaption.Size = new System.Drawing.Size(45, 13);
            this.lblVolumeCaption.TabIndex = 3;
            this.lblVolumeCaption.Text = "Volume:";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(130, 56);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(350, 45);
            this.tbVolume.TabIndex = 4;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.Value = 70;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Location = new System.Drawing.Point(490, 64);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblVolumeValue.TabIndex = 5;
            this.lblVolumeValue.Text = "70%";
            // 
            // btnTestSpeakerLeft
            // 
            this.btnTestSpeakerLeft.Location = new System.Drawing.Point(16, 112);
            this.btnTestSpeakerLeft.Name = "btnTestSpeakerLeft";
            this.btnTestSpeakerLeft.Size = new System.Drawing.Size(180, 32);
            this.btnTestSpeakerLeft.TabIndex = 6;
            this.btnTestSpeakerLeft.Text = "Test Left Channel";
            this.btnTestSpeakerLeft.UseVisualStyleBackColor = false;
            this.btnTestSpeakerLeft.Click += new System.EventHandler(this.btnTestSpeakerLeft_Click);
            // 
            // btnTestSpeakerRight
            // 
            this.btnTestSpeakerRight.Location = new System.Drawing.Point(204, 112);
            this.btnTestSpeakerRight.Name = "btnTestSpeakerRight";
            this.btnTestSpeakerRight.Size = new System.Drawing.Size(180, 32);
            this.btnTestSpeakerRight.TabIndex = 7;
            this.btnTestSpeakerRight.Text = "Test Right Channel";
            this.btnTestSpeakerRight.UseVisualStyleBackColor = false;
            this.btnTestSpeakerRight.Click += new System.EventHandler(this.btnTestSpeakerRight_Click);
            // 
            // btnTestSpeakerBoth
            // 
            this.btnTestSpeakerBoth.Location = new System.Drawing.Point(392, 112);
            this.btnTestSpeakerBoth.Name = "btnTestSpeakerBoth";
            this.btnTestSpeakerBoth.Size = new System.Drawing.Size(180, 32);
            this.btnTestSpeakerBoth.TabIndex = 8;
            this.btnTestSpeakerBoth.Text = "Test Both Channels";
            this.btnTestSpeakerBoth.UseVisualStyleBackColor = false;
            this.btnTestSpeakerBoth.Click += new System.EventHandler(this.btnTestSpeakerBoth_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(12, 356);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(596, 34);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Ready.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 402);
            this.Controls.Add(this.grpMic);
            this.Controls.Add(this.grpSpeaker);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mic & Speaker Tester (.NET 3.5)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMic.ResumeLayout(false);
            this.grpMic.PerformLayout();
            this.grpSpeaker.ResumeLayout(false);
            this.grpSpeaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
