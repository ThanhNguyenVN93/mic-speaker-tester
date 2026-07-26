using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using frm_sound_mic_test.Services;

namespace frm_sound_mic_test
{
    public partial class Form1 : Form
    {
        private readonly AudioDeviceService deviceService = new AudioDeviceService();
        private readonly MicTestService micTestService = new MicTestService();
        private readonly SpeakerTestService speakerTestService = new SpeakerTestService();

        private TestChannel? activeSpeakerChannel;
        private bool hasReceivedAudioSignal;
        private readonly Timer silenceCheckTimer = new Timer { Interval = 3000 };

        public Form1()
        {
            InitializeComponent();
            Icon = LoadEmbeddedIcon();

            micTestService.OnLevelChanged += MicTestService_OnLevelChanged;
            micTestService.OnDeviceError += MicTestService_OnDeviceError;
            speakerTestService.OnDeviceError += SpeakerTestService_OnDeviceError;
            silenceCheckTimer.Tick += SilenceCheckTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyDarkTitleBar();
            LoadMicDevices();
            LoadSpeakerDevices();
            UpdateSpeakerButtons();
        }

        #region Dark title bar (Windows 10 2004+/11)

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int value, int valueSize);

        private void ApplyDarkTitleBar()
        {
            try
            {
                int enabled = 1;
                const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
                const int DWMWA_USE_IMMERSIVE_DARK_MODE_OLD = 19;
                DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref enabled, sizeof(int));
                DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_OLD, ref enabled, sizeof(int));
            }
            catch
            {
                // Older Windows versions don't support the dark title bar — ignore, no functional impact.
            }
        }

        #endregion

        #region Device list loading

        private void LoadMicDevices()
        {
            LoadDevicesInto(cbMicDevice, deviceService.GetInputDevices());
        }

        private void LoadSpeakerDevices()
        {
            LoadDevicesInto(cbSpeakerDevice, deviceService.GetOutputDevices());
        }

        private static void LoadDevicesInto(ComboBox combo, List<AudioDeviceInfo> devices)
        {
            int previousIndex = -1;
            var previous = combo.SelectedItem as AudioDeviceInfo;
            if (previous != null)
            {
                previousIndex = previous.DeviceIndex;
            }

            combo.Items.Clear();
            foreach (var device in devices)
            {
                combo.Items.Add(device);
            }

            if (combo.Items.Count == 0)
            {
                return;
            }

            int selectIndex = devices.FindIndex(d => d.DeviceIndex == previousIndex);
            if (selectIndex < 0)
            {
                selectIndex = devices.FindIndex(d => d.IsDefault);
            }
            if (selectIndex < 0)
            {
                selectIndex = 0;
            }
            combo.SelectedIndex = selectIndex;
        }

        private void btnRefreshMic_Click(object sender, EventArgs e)
        {
            LoadMicDevices();
            SetStatus("Microphone device list refreshed.");
        }

        private void btnRefreshSpeaker_Click(object sender, EventArgs e)
        {
            LoadSpeakerDevices();
            SetStatus("Speaker device list refreshed.");
        }

        #endregion

        #region Mic test

        private void btnTestMic_Click(object sender, EventArgs e)
        {
            if (micTestService.IsCapturing)
            {
                silenceCheckTimer.Stop();
                micTestService.StopCapture();
                SetMicButtonState(isCapturing: false);
                pbMicLevel.Value = 0;
                tglMicMonitor.Checked = false;
                tglMicMonitor.Enabled = false;
                SetStatus("Mic test stopped.");
                return;
            }

            var selected = cbMicDevice.SelectedItem as AudioDeviceInfo;
            if (selected == null)
            {
                SetStatus("No microphone device selected.");
                return;
            }

            try
            {
                hasReceivedAudioSignal = false;
                micTestService.StartCapture(selected.DeviceIndex);
                SetMicButtonState(isCapturing: true);
                tglMicMonitor.Enabled = true;
                SetStatus("Testing microphone: " + selected.Name);
                silenceCheckTimer.Start();
            }
            catch (Exception ex)
            {
                SetStatus("Could not open microphone: " + ex.Message);
            }
        }

        private void SetMicButtonState(bool isCapturing)
        {
            btnTestMic.Text = isCapturing ? "Stop Mic Test" : "Start Mic Test";
            btnTestMic.FillColor = isCapturing ? Theme.Danger : Theme.Accent;
            btnTestMic.HoverState.FillColor = isCapturing ? Theme.DangerHover : Theme.AccentHover;
            btnTestMic.PressedColor = isCapturing ? Theme.Danger : Theme.AccentPressed;
        }

        private void SilenceCheckTimer_Tick(object sender, EventArgs e)
        {
            silenceCheckTimer.Stop();
            if (micTestService.IsCapturing && !hasReceivedAudioSignal)
            {
                SetStatus("No audio detected from the microphone. Check: Windows Settings > Privacy & security > "
                    + "Microphone > enable \"Let desktop apps access your microphone\"; make sure the mic isn't "
                    + "muted/at 0 volume in the Sound Control Panel; and that the correct device is selected.");
            }
        }

        private void tglMicMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (!micTestService.IsCapturing)
            {
                return;
            }

            if (tglMicMonitor.Checked)
            {
                var speaker = cbSpeakerDevice.SelectedItem as AudioDeviceInfo;
                if (speaker == null)
                {
                    SetStatus("No speaker device selected for monitoring.");
                    tglMicMonitor.Checked = false;
                    return;
                }

                micTestService.SetMonitoring(true, speaker.DeviceIndex);
                SetStatus("Monitoring microphone through: " + speaker.Name);
            }
            else
            {
                micTestService.SetMonitoring(false, -1);
                SetStatus("Monitoring stopped.");
            }
        }

        private void MicTestService_OnLevelChanged(int level)
        {
            SafeInvoke(() =>
            {
                if (level > 1)
                {
                    hasReceivedAudioSignal = true;
                }
                pbMicLevel.Value = level;
                pbMicLevel.ProgressColor = LevelToColor(level);
                pbMicLevel.ProgressColor2 = pbMicLevel.ProgressColor;
            });
        }

        private static Color LevelToColor(int level)
        {
            if (level >= 85) return Theme.LevelHigh;
            if (level >= 60) return Theme.LevelMid;
            return Theme.LevelLow;
        }

        private void MicTestService_OnDeviceError(Exception ex)
        {
            SafeInvoke(() =>
            {
                silenceCheckTimer.Stop();
                SetMicButtonState(isCapturing: false);
                pbMicLevel.Value = 0;
                tglMicMonitor.Checked = false;
                tglMicMonitor.Enabled = false;
                SetStatus("Microphone disconnected or errored: " + ex.Message);
            });
        }

        #endregion

        #region Speaker test

        private void btnTestSpeakerLeft_Click(object sender, EventArgs e)
        {
            ToggleSpeakerTest(TestChannel.Left);
        }

        private void btnTestSpeakerRight_Click(object sender, EventArgs e)
        {
            ToggleSpeakerTest(TestChannel.Right);
        }

        private void btnTestSpeakerBoth_Click(object sender, EventArgs e)
        {
            ToggleSpeakerTest(TestChannel.Both);
        }

        private void ToggleSpeakerTest(TestChannel channel)
        {
            if (activeSpeakerChannel == channel)
            {
                speakerTestService.Stop();
                activeSpeakerChannel = null;
                UpdateSpeakerButtons();
                SetStatus("Speaker test stopped.");
                return;
            }

            var selected = cbSpeakerDevice.SelectedItem as AudioDeviceInfo;
            if (selected == null)
            {
                SetStatus("No speaker device selected.");
                return;
            }

            try
            {
                speakerTestService.PlayTestTone(selected.DeviceIndex, channel, tbVolume.Value / 100f);
                activeSpeakerChannel = channel;
                UpdateSpeakerButtons();
                SetStatus("Playing test tone (" + ChannelLabel(channel) + ") to: " + selected.Name);
            }
            catch (Exception ex)
            {
                SetStatus("Could not play to speaker: " + ex.Message);
            }
        }

        private void UpdateSpeakerButtons()
        {
            SetSpeakerButtonState(btnTestSpeakerLeft, activeSpeakerChannel == TestChannel.Left, "Test Left Channel", "Stop (Left)");
            SetSpeakerButtonState(btnTestSpeakerRight, activeSpeakerChannel == TestChannel.Right, "Test Right Channel", "Stop (Right)");
            SetSpeakerButtonState(btnTestSpeakerBoth, activeSpeakerChannel == TestChannel.Both, "Test Both Channels", "Stop (Both)");
        }

        private static void SetSpeakerButtonState(Guna.UI2.WinForms.Guna2Button button, bool isActive, string idleText, string activeText)
        {
            button.Text = isActive ? activeText : idleText;
            if (isActive)
            {
                button.FillColor = Theme.Accent;
                button.ForeColor = Color.White;
                button.BorderColor = Theme.Accent;
            }
            else
            {
                button.FillColor = Theme.InputBackground;
                button.ForeColor = Theme.TextPrimary;
                button.BorderColor = Theme.CardBorder;
            }
        }

        private static string ChannelLabel(TestChannel channel)
        {
            switch (channel)
            {
                case TestChannel.Left: return "left channel";
                case TestChannel.Right: return "right channel";
                default: return "both channels";
            }
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVolumeValue.Text = tbVolume.Value + "%";
        }

        private void SpeakerTestService_OnDeviceError(Exception ex)
        {
            SafeInvoke(() =>
            {
                activeSpeakerChannel = null;
                UpdateSpeakerButtons();
                SetStatus("Speaker disconnected or errored: " + ex.Message);
            });
        }

        #endregion

        private static Icon LoadEmbeddedIcon()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("frm_sound_mic_test.Resources.AppIcon.ico"))
            {
                return stream != null ? new Icon(stream) : null;
            }
        }

        private void SetStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void SafeInvoke(Action action)
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        private void lnkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupportForm.OpenUrl("https://www.facebook.com/PycCodeTools");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppPreferences.ShouldShowSupportDialog())
            {
                using (var supportForm = new SupportForm())
                {
                    supportForm.ShowDialog(this);
                }
            }

            silenceCheckTimer.Dispose();
            micTestService.Dispose();
            speakerTestService.Dispose();
        }
    }
}
