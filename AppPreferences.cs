using System;
using System.IO;

namespace frm_sound_mic_test
{
    // Small standalone preference flag, stored next to other per-user app data instead of via
    // ApplicationSettingsBase - that mechanism keys its storage path by assembly version, which
    // would silently "forget" this preference every time the app is rebuilt with a new version.
    internal static class AppPreferences
    {
        private static string PreferencesDirectory
        {
            get
            {
                return Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "MicSpeakerTester");
            }
        }

        private static string HideSupportDialogFlagPath
        {
            get { return Path.Combine(PreferencesDirectory, "hide_support_dialog.flag"); }
        }

        public static bool ShouldShowSupportDialog()
        {
            try
            {
                return !File.Exists(HideSupportDialogFlagPath);
            }
            catch
            {
                return true;
            }
        }

        public static void HideSupportDialogFromNowOn()
        {
            try
            {
                Directory.CreateDirectory(PreferencesDirectory);
                File.WriteAllText(HideSupportDialogFlagPath, DateTime.UtcNow.ToString("o"));
            }
            catch
            {
                // Best-effort preference only - if it can't be written, the dialog just shows again next time.
            }
        }
    }
}
