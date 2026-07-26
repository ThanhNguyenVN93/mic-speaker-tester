using System;
using System.Collections.Generic;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace frm_sound_mic_test.Services
{
    public class AudioDeviceInfo
    {
        public int DeviceIndex { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }

        public override string ToString()
        {
            return IsDefault ? Name + "  (Default)" : Name;
        }
    }

    public class AudioDeviceService
    {
        public List<AudioDeviceInfo> GetInputDevices()
        {
            var devices = new List<AudioDeviceInfo>();
            for (int i = 0; i < WaveInEvent.DeviceCount; i++)
            {
                var caps = WaveInEvent.GetCapabilities(i);
                devices.Add(new AudioDeviceInfo { DeviceIndex = i, Name = caps.ProductName });
            }
            MarkDefault(devices, DataFlow.Capture);
            return devices;
        }

        public List<AudioDeviceInfo> GetOutputDevices()
        {
            var devices = new List<AudioDeviceInfo>();
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var caps = WaveOut.GetCapabilities(i);
                devices.Add(new AudioDeviceInfo { DeviceIndex = i, Name = caps.ProductName });
            }
            MarkDefault(devices, DataFlow.Render);
            return devices;
        }

        // WaveIn/WaveOut (legacy MME) don't expose which device is Windows' default,
        // so probe via WASAPI (MMDeviceEnumerator) and fuzzy-match the display name.
        private void MarkDefault(List<AudioDeviceInfo> devices, DataFlow flow)
        {
            try
            {
                using (var enumerator = new MMDeviceEnumerator())
                {
                    var defaultDevice = enumerator.GetDefaultAudioEndpoint(flow, Role.Console);
                    string defaultName = defaultDevice.FriendlyName;

                    AudioDeviceInfo bestMatch = null;
                    foreach (var device in devices)
                    {
                        if (defaultName.IndexOf(device.Name, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            device.Name.IndexOf(defaultName, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            bestMatch = device;
                            break;
                        }
                    }
                    if (bestMatch != null)
                    {
                        bestMatch.IsDefault = true;
                    }
                }
            }
            catch
            {
                // Couldn't determine the default device (e.g. no devices present) — ignore, leave the list unmarked.
            }
        }
    }
}
