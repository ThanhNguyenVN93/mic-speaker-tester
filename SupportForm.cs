using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace frm_sound_mic_test
{
    public partial class SupportForm : Form
    {
        private const string KofiUrl = "https://ko-fi.com/thanhnguyen150993";
        private const int CollapsedHeight = 274;
        private const int ExpandedHeight = 546;

        public SupportForm()
        {
            InitializeComponent();
            picMomo.Image = LoadEmbeddedImage("frm_sound_mic_test.Resources.Donate.momo.jpg");
            picTcb.Image = LoadEmbeddedImage("frm_sound_mic_test.Resources.Donate.tcb.jpg");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            lblHint.Visible = false;
            pnlSeparator.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;

            lblThanks.Visible = true;
            picMomo.Visible = true;
            picTcb.Visible = true;
            lblQrCaption.Visible = true;
            btnKofi.Visible = true;
            btnClose.Visible = true;

            int heightDelta = ExpandedHeight - ClientSize.Height;
            ClientSize = new Size(ClientSize.Width, ExpandedHeight);
            Top -= heightDelta / 2;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKofi_Click(object sender, EventArgs e)
        {
            OpenUrl(KofiUrl);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (chkDontShowAgain.Checked)
            {
                AppPreferences.HideSupportDialogFromNowOn();
            }
            base.OnFormClosing(e);
        }

        internal static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                // Best-effort - if the default browser can't be launched there's nothing else to do here.
            }
        }

        private static Image LoadEmbeddedImage(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                return stream != null ? Image.FromStream(stream) : null;
            }
        }
    }
}
