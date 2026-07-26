# Mic & Speaker Tester — Spec for Claude Code

## Goal
A compact, **portable** Windows Forms tool (single exe, no separate .NET runtime install beyond the Framework already on the machine), replacing the need to go to onlinemictest.com. Features: microphone testing (VU meter, loopback monitoring) and speaker testing (play a tone/sample, test left/right channels individually).

## Tech stack
- .NET Framework 3.5 (WinForms)
- UI: **Guna.UI2.WinForms** (NuGet package `Guna.UI2.WinForms`)
- Audio: **NAudio** (NuGet package `NAudio`)
- Single-exe packaging: `Costura.Fody` (embeds NAudio.dll + Guna.UI2.WinForms.dll into the exe) — check Costura.Fody compatibility with the .NET 3.5 target; if incompatible, fall back to `ILRepack`.

> Note for Claude Code: check which NAudio version supports .NET Framework 3.5 (newer NAudio requires .NET 4.5+ — if that's a blocker, use NAudio 1.7.x or lower, or consider raising the target to .NET Framework 4.x if compatibility allows).

## Project structure
```
MicSpeakerTester/
├─ Program.cs
├─ Forms/
│  ├─ frmMain.cs
│  ├─ frmMain.Designer.cs
│  └─ frmMain.resx
├─ Services/
│  ├─ AudioDeviceService.cs      // enumerate mic/speaker devices
│  ├─ MicTestService.cs          // capture + VU meter + loopback
│  └─ SpeakerTestService.cs      // playback tone/wav, test L/R channel
├─ Resources/
│  └─ test_tone.wav              // (optional) sample file for speaker testing
└─ MicSpeakerTester.csproj
```

## UI (frmMain) — using Guna.UI2 controls

| Control | Variable name | Role |
|---|---|---|
| `Guna2ComboBox` | `cbMicDevice` | Select mic device (bound from `AudioDeviceService.GetInputDevices()`) |
| `Guna2ComboBox` | `cbSpeakerDevice` | Select speaker device (bound from `AudioDeviceService.GetOutputDevices()`) |
| `Guna2ProgressBar` | `pbMicLevel` | VU meter showing real-time mic level (0–100) |
| `Guna2ToggleSwitch` | `tglMicMonitor` | Toggle loopback — monitor the mic through the speaker instantly |
| `Guna2Button` | `btnTestMic` | Start/Stop mic capture |
| `Guna2Button` | `btnTestSpeakerLeft` | Play tone on the left channel only |
| `Guna2Button` | `btnTestSpeakerRight` | Play tone on the right channel only |
| `Guna2Button` | `btnTestSpeakerBoth` | Play tone on both channels (general speaker test) |
| `Guna2TrackBar` | `tbVolume` | Adjust the speaker test tone's volume |
| `Guna2HtmlLabel` | `lblStatus` | Show status (testing, device error, etc.) |

## Services — main method signatures

### AudioDeviceService.cs
```csharp
public class AudioDeviceService
{
    // Returns the list of input devices (mic) — uses WaveIn.DeviceCount / WaveInCapabilities
    public List<AudioDeviceInfo> GetInputDevices();

    // Returns the list of output devices (speaker) — uses WaveOut.DeviceCount / WaveOutCapabilities
    public List<AudioDeviceInfo> GetOutputDevices();
}

public class AudioDeviceInfo
{
    public int DeviceIndex { get; set; }
    public string Name { get; set; }
}
```

### MicTestService.cs
```csharp
public class MicTestService : IDisposable
{
    // Starts capturing from deviceIndex, raises an event on every new buffer
    public void StartCapture(int deviceIndex);

    public void StopCapture();

    // Toggles routing mic audio straight to the speaker (loopback) to test latency / rattle
    public void SetMonitoring(bool enabled, int outputDeviceIndex);

    // Event reporting the current level (0-100) to drive the VU meter
    public event Action<int> OnLevelChanged;

    // Uses NAudio: WaveInEvent (capture) + BufferedWaveProvider + WaveOutEvent (when monitoring)
    // Computes RMS/peak from the buffer to produce the VU meter level
}
```

### SpeakerTestService.cs
```csharp
public enum TestChannel { Left, Right, Both }

public class SpeakerTestService : IDisposable
{
    // Plays a sine tone (or a sample wav file in Resources) to deviceIndex,
    // channel selects which channel(s) it plays on, volume 0.0-1.0
    public void PlayTestTone(int deviceIndex, TestChannel channel, float volume);

    public void Stop();

    // Uses NAudio: SignalGenerator (generates a sine wave) or WaveFileReader (if using a sample file)
    // + WaveOutEvent, set up a PanningSampleProvider to split left/right channels
}
```

## Main flow (frmMain)

1. `Form_Load`: calls `AudioDeviceService` to load the mic/speaker lists into the two comboboxes, selecting the system's default device.
2. `btnTestMic_Click`: toggles Start/Stop `MicTestService.StartCapture(cbMicDevice.SelectedIndex)`; subscribes to `OnLevelChanged` to update `pbMicLevel.Value`.
3. `tglMicMonitor_CheckedChanged`: calls `MicTestService.SetMonitoring(checked, cbSpeakerDevice.SelectedIndex)`.
4. `btnTestSpeakerLeft/Right/Both_Click`: calls `SpeakerTestService.PlayTestTone(...)` with the matching channel, using `tbVolume.Value / 100f` as the volume.
5. `Form_Closing`: makes sure both `MicTestService` and `SpeakerTestService` are `Dispose()`d to release the audio devices.

## Additional work (left open for Claude Code to decide at implementation time)
- Handle exceptions when a device is unplugged mid-test (USB mic, Bluetooth headset...).
- Consider showing which device is currently Windows' default (marked "Default").
- Consider adding a "Refresh devices" button to re-enumerate when devices are plugged/unplugged.
