namespace frm_sound_mic_test
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

        private Guna.UI2.WinForms.Guna2Panel groupMic;
        private System.Windows.Forms.Label lblMicTitle;
        private System.Windows.Forms.Label lblMicDeviceCaption;
        private Guna.UI2.WinForms.Guna2Button btnRefreshMic;
        private Guna.UI2.WinForms.Guna2ProgressBar pbMicLevel;
        private Guna.UI2.WinForms.Guna2Button btnTestMic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglMicMonitor;
        private System.Windows.Forms.Label lblMonitorCaption;

        private Guna.UI2.WinForms.Guna2Panel groupSpeaker;
        private System.Windows.Forms.Label lblSpeakerTitle;
        private System.Windows.Forms.Label lblSpeakerDeviceCaption;
        private Guna.UI2.WinForms.Guna2ComboBox cbSpeakerDevice;
        private Guna.UI2.WinForms.Guna2Button btnRefreshSpeaker;
        private System.Windows.Forms.Label lblVolumeCaption;
        private Guna.UI2.WinForms.Guna2TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolumeValue;
        private Guna.UI2.WinForms.Guna2Button btnTestSpeakerLeft;
        private Guna.UI2.WinForms.Guna2Button btnTestSpeakerRight;
        private Guna.UI2.WinForms.Guna2Button btnTestSpeakerBoth;

        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private System.Windows.Forms.LinkLabel lnkFeedback;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupMic = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMicTitle = new System.Windows.Forms.Label();
            this.lblMicDeviceCaption = new System.Windows.Forms.Label();
            this.cbMicDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefreshMic = new Guna.UI2.WinForms.Guna2Button();
            this.pbMicLevel = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnTestMic = new Guna.UI2.WinForms.Guna2Button();
            this.tglMicMonitor = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblMonitorCaption = new System.Windows.Forms.Label();
            this.groupSpeaker = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSpeakerTitle = new System.Windows.Forms.Label();
            this.lblSpeakerDeviceCaption = new System.Windows.Forms.Label();
            this.cbSpeakerDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefreshSpeaker = new Guna.UI2.WinForms.Guna2Button();
            this.lblVolumeCaption = new System.Windows.Forms.Label();
            this.tbVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.btnTestSpeakerLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnTestSpeakerRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnTestSpeakerBoth = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lnkFeedback = new System.Windows.Forms.LinkLabel();
            this.groupMic.SuspendLayout();
            this.groupSpeaker.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMic
            // 
            this.groupMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.groupMic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.groupMic.BorderRadius = 14;
            this.groupMic.BorderThickness = 1;
            this.groupMic.Controls.Add(this.lblMicTitle);
            this.groupMic.Controls.Add(this.lblMicDeviceCaption);
            this.groupMic.Controls.Add(this.cbMicDevice);
            this.groupMic.Controls.Add(this.btnRefreshMic);
            this.groupMic.Controls.Add(this.pbMicLevel);
            this.groupMic.Controls.Add(this.btnTestMic);
            this.groupMic.Controls.Add(this.tglMicMonitor);
            this.groupMic.Controls.Add(this.lblMonitorCaption);
            this.groupMic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.groupMic.Location = new System.Drawing.Point(14, 14);
            this.groupMic.Name = "groupMic";
            this.groupMic.Size = new System.Drawing.Size(600, 190);
            this.groupMic.TabIndex = 0;
            // 
            // lblMicTitle
            // 
            this.lblMicTitle.AutoSize = true;
            this.lblMicTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMicTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.lblMicTitle.Location = new System.Drawing.Point(20, 14);
            this.lblMicTitle.Name = "lblMicTitle";
            this.lblMicTitle.Size = new System.Drawing.Size(93, 20);
            this.lblMicTitle.TabIndex = 0;
            this.lblMicTitle.Text = "Microphone";
            // 
            // lblMicDeviceCaption
            // 
            this.lblMicDeviceCaption.AutoSize = true;
            this.lblMicDeviceCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblMicDeviceCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMicDeviceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblMicDeviceCaption.Location = new System.Drawing.Point(20, 40);
            this.lblMicDeviceCaption.Name = "lblMicDeviceCaption";
            this.lblMicDeviceCaption.Size = new System.Drawing.Size(112, 15);
            this.lblMicDeviceCaption.TabIndex = 0;
            this.lblMicDeviceCaption.Text = "Microphone device:";
            // 
            // cbMicDevice
            // 
            this.cbMicDevice.BackColor = System.Drawing.Color.Transparent;
            this.cbMicDevice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.cbMicDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMicDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMicDevice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.cbMicDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.cbMicDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.cbMicDevice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbMicDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.cbMicDevice.ItemHeight = 30;
            this.cbMicDevice.Location = new System.Drawing.Point(138, 34);
            this.cbMicDevice.Name = "cbMicDevice";
            this.cbMicDevice.Size = new System.Drawing.Size(346, 36);
            this.cbMicDevice.TabIndex = 1;
            // 
            // btnRefreshMic
            // 
            this.btnRefreshMic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnRefreshMic.BorderRadius = 8;
            this.btnRefreshMic.BorderThickness = 1;
            this.btnRefreshMic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnRefreshMic.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshMic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnRefreshMic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnRefreshMic.Location = new System.Drawing.Point(500, 34);
            this.btnRefreshMic.Name = "btnRefreshMic";
            this.btnRefreshMic.Size = new System.Drawing.Size(94, 36);
            this.btnRefreshMic.TabIndex = 2;
            this.btnRefreshMic.Text = "Refresh";
            this.btnRefreshMic.Click += new System.EventHandler(this.btnRefreshMic_Click);
            // 
            // pbMicLevel
            // 
            this.pbMicLevel.BorderRadius = 6;
            this.pbMicLevel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pbMicLevel.Location = new System.Drawing.Point(20, 84);
            this.pbMicLevel.Name = "pbMicLevel";
            this.pbMicLevel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(208)))), ((int)(((byte)(127)))));
            this.pbMicLevel.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(208)))), ((int)(((byte)(127)))));
            this.pbMicLevel.Size = new System.Drawing.Size(580, 26);
            this.pbMicLevel.TabIndex = 3;
            this.pbMicLevel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnTestMic
            // 
            this.btnTestMic.BorderRadius = 10;
            this.btnTestMic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.btnTestMic.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTestMic.ForeColor = System.Drawing.Color.White;
            this.btnTestMic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.btnTestMic.Location = new System.Drawing.Point(20, 126);
            this.btnTestMic.Name = "btnTestMic";
            this.btnTestMic.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(74)))), ((int)(((byte)(220)))));
            this.btnTestMic.Size = new System.Drawing.Size(200, 42);
            this.btnTestMic.TabIndex = 4;
            this.btnTestMic.Text = "Start Mic Test";
            this.btnTestMic.Click += new System.EventHandler(this.btnTestMic_Click);
            // 
            // tglMicMonitor
            // 
            this.tglMicMonitor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.tglMicMonitor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglMicMonitor.Enabled = false;
            this.tglMicMonitor.Location = new System.Drawing.Point(240, 134);
            this.tglMicMonitor.Name = "tglMicMonitor";
            this.tglMicMonitor.Size = new System.Drawing.Size(50, 24);
            this.tglMicMonitor.TabIndex = 5;
            this.tglMicMonitor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.tglMicMonitor.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tglMicMonitor.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.tglMicMonitor.CheckedChanged += new System.EventHandler(this.tglMicMonitor_CheckedChanged);
            // 
            // lblMonitorCaption
            // 
            this.lblMonitorCaption.AutoSize = true;
            this.lblMonitorCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblMonitorCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMonitorCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblMonitorCaption.Location = new System.Drawing.Point(298, 138);
            this.lblMonitorCaption.Name = "lblMonitorCaption";
            this.lblMonitorCaption.Size = new System.Drawing.Size(222, 15);
            this.lblMonitorCaption.TabIndex = 6;
            this.lblMonitorCaption.Text = "Monitor mic through speaker (loopback)";
            // 
            // groupSpeaker
            // 
            this.groupSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.groupSpeaker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.groupSpeaker.BorderRadius = 14;
            this.groupSpeaker.BorderThickness = 1;
            this.groupSpeaker.Controls.Add(this.lblSpeakerTitle);
            this.groupSpeaker.Controls.Add(this.lblSpeakerDeviceCaption);
            this.groupSpeaker.Controls.Add(this.cbSpeakerDevice);
            this.groupSpeaker.Controls.Add(this.btnRefreshSpeaker);
            this.groupSpeaker.Controls.Add(this.lblVolumeCaption);
            this.groupSpeaker.Controls.Add(this.tbVolume);
            this.groupSpeaker.Controls.Add(this.lblVolumeValue);
            this.groupSpeaker.Controls.Add(this.btnTestSpeakerLeft);
            this.groupSpeaker.Controls.Add(this.btnTestSpeakerRight);
            this.groupSpeaker.Controls.Add(this.btnTestSpeakerBoth);
            this.groupSpeaker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.groupSpeaker.Location = new System.Drawing.Point(14, 216);
            this.groupSpeaker.Name = "groupSpeaker";
            this.groupSpeaker.Size = new System.Drawing.Size(600, 206);
            this.groupSpeaker.TabIndex = 7;
            // 
            // lblSpeakerTitle
            // 
            this.lblSpeakerTitle.AutoSize = true;
            this.lblSpeakerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeakerTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSpeakerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.lblSpeakerTitle.Location = new System.Drawing.Point(20, 14);
            this.lblSpeakerTitle.Name = "lblSpeakerTitle";
            this.lblSpeakerTitle.Size = new System.Drawing.Size(64, 20);
            this.lblSpeakerTitle.TabIndex = 0;
            this.lblSpeakerTitle.Text = "Speaker";
            // 
            // lblSpeakerDeviceCaption
            // 
            this.lblSpeakerDeviceCaption.AutoSize = true;
            this.lblSpeakerDeviceCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeakerDeviceCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSpeakerDeviceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblSpeakerDeviceCaption.Location = new System.Drawing.Point(20, 40);
            this.lblSpeakerDeviceCaption.Name = "lblSpeakerDeviceCaption";
            this.lblSpeakerDeviceCaption.Size = new System.Drawing.Size(88, 15);
            this.lblSpeakerDeviceCaption.TabIndex = 0;
            this.lblSpeakerDeviceCaption.Text = "Speaker device:";
            // 
            // cbSpeakerDevice
            // 
            this.cbSpeakerDevice.BackColor = System.Drawing.Color.Transparent;
            this.cbSpeakerDevice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.cbSpeakerDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpeakerDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeakerDevice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.cbSpeakerDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.cbSpeakerDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.cbSpeakerDevice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSpeakerDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.cbSpeakerDevice.ItemHeight = 30;
            this.cbSpeakerDevice.Location = new System.Drawing.Point(126, 34);
            this.cbSpeakerDevice.Name = "cbSpeakerDevice";
            this.cbSpeakerDevice.Size = new System.Drawing.Size(358, 36);
            this.cbSpeakerDevice.TabIndex = 1;
            // 
            // btnRefreshSpeaker
            // 
            this.btnRefreshSpeaker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnRefreshSpeaker.BorderRadius = 8;
            this.btnRefreshSpeaker.BorderThickness = 1;
            this.btnRefreshSpeaker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnRefreshSpeaker.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshSpeaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnRefreshSpeaker.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnRefreshSpeaker.Location = new System.Drawing.Point(500, 34);
            this.btnRefreshSpeaker.Name = "btnRefreshSpeaker";
            this.btnRefreshSpeaker.Size = new System.Drawing.Size(94, 36);
            this.btnRefreshSpeaker.TabIndex = 2;
            this.btnRefreshSpeaker.Text = "Refresh";
            this.btnRefreshSpeaker.Click += new System.EventHandler(this.btnRefreshSpeaker_Click);
            // 
            // lblVolumeCaption
            // 
            this.lblVolumeCaption.AutoSize = true;
            this.lblVolumeCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblVolumeCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVolumeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblVolumeCaption.Location = new System.Drawing.Point(20, 90);
            this.lblVolumeCaption.Name = "lblVolumeCaption";
            this.lblVolumeCaption.Size = new System.Drawing.Size(50, 15);
            this.lblVolumeCaption.TabIndex = 3;
            this.lblVolumeCaption.Text = "Volume:";
            // 
            // tbVolume
            // 
            this.tbVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.tbVolume.Location = new System.Drawing.Point(126, 82);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(400, 45);
            this.tbVolume.TabIndex = 4;
            this.tbVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.tbVolume.Value = 70;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVolumeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVolumeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.lblVolumeValue.Location = new System.Drawing.Point(536, 90);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(31, 15);
            this.lblVolumeValue.TabIndex = 5;
            this.lblVolumeValue.Text = "70%";
            // 
            // btnTestSpeakerLeft
            // 
            this.btnTestSpeakerLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerLeft.BorderRadius = 10;
            this.btnTestSpeakerLeft.BorderThickness = 1;
            this.btnTestSpeakerLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnTestSpeakerLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestSpeakerLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnTestSpeakerLeft.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerLeft.Location = new System.Drawing.Point(20, 142);
            this.btnTestSpeakerLeft.Name = "btnTestSpeakerLeft";
            this.btnTestSpeakerLeft.Size = new System.Drawing.Size(184, 44);
            this.btnTestSpeakerLeft.TabIndex = 6;
            this.btnTestSpeakerLeft.Text = "Test Left Channel";
            this.btnTestSpeakerLeft.Click += new System.EventHandler(this.btnTestSpeakerLeft_Click);
            // 
            // btnTestSpeakerRight
            // 
            this.btnTestSpeakerRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerRight.BorderRadius = 10;
            this.btnTestSpeakerRight.BorderThickness = 1;
            this.btnTestSpeakerRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnTestSpeakerRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestSpeakerRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnTestSpeakerRight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerRight.Location = new System.Drawing.Point(212, 142);
            this.btnTestSpeakerRight.Name = "btnTestSpeakerRight";
            this.btnTestSpeakerRight.Size = new System.Drawing.Size(184, 44);
            this.btnTestSpeakerRight.TabIndex = 7;
            this.btnTestSpeakerRight.Text = "Test Right Channel";
            this.btnTestSpeakerRight.Click += new System.EventHandler(this.btnTestSpeakerRight_Click);
            // 
            // btnTestSpeakerBoth
            // 
            this.btnTestSpeakerBoth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerBoth.BorderRadius = 10;
            this.btnTestSpeakerBoth.BorderThickness = 1;
            this.btnTestSpeakerBoth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnTestSpeakerBoth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestSpeakerBoth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnTestSpeakerBoth.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.btnTestSpeakerBoth.Location = new System.Drawing.Point(404, 142);
            this.btnTestSpeakerBoth.Name = "btnTestSpeakerBoth";
            this.btnTestSpeakerBoth.Size = new System.Drawing.Size(184, 44);
            this.btnTestSpeakerBoth.TabIndex = 8;
            this.btnTestSpeakerBoth.Text = "Test Both Channels";
            this.btnTestSpeakerBoth.Click += new System.EventHandler(this.btnTestSpeakerBoth_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.pnlFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.pnlFooter.BorderRadius = 12;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.lblStatus);
            this.pnlFooter.Controls.Add(this.lnkFeedback);
            this.pnlFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.pnlFooter.Location = new System.Drawing.Point(14, 436);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(600, 44);
            this.pnlFooter.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblStatus.Location = new System.Drawing.Point(16, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready.";
            // 
            // lnkFeedback
            // 
            this.lnkFeedback.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.lnkFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lnkFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkFeedback.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.lnkFeedback.Location = new System.Drawing.Point(516, 13);
            this.lnkFeedback.Name = "lnkFeedback";
            this.lnkFeedback.Size = new System.Drawing.Size(68, 18);
            this.lnkFeedback.TabIndex = 1;
            this.lnkFeedback.TabStop = true;
            this.lnkFeedback.Text = "Feedback";
            this.lnkFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkFeedback.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.lnkFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFeedback_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(628, 494);
            this.Controls.Add(this.groupMic);
            this.Controls.Add(this.groupSpeaker);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mic & Speaker Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupMic.ResumeLayout(false);
            this.groupMic.PerformLayout();
            this.groupSpeaker.ResumeLayout(false);
            this.groupSpeaker.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbMicDevice;
    }
}
