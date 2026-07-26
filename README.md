# Mic & Speaker Tester

A small, portable Windows Forms tool for testing your microphone and speakers — a local replacement for sites like onlinemictest.com.

- **Microphone test**: live VU meter, loopback monitoring (hear your own mic through the speakers instantly), auto-detect the Windows default device, refresh device list on demand.
- **Speaker test**: play a sine test tone on the left channel, right channel, or both, with a volume slider.
- Clear on-screen guidance if no audio is detected (privacy permissions, muted device, wrong device selected, etc).

## Downloads

This repo ships two builds, both compiled to a **single executable file** — no installer, no extra DLLs to copy around.

| Build | Target | Notes |
|---|---|---|
| `MicSpeakerTester.exe` | .NET Framework 4.7.2 | Modern dark UI (Guna.UI2.WinForms), all dependencies embedded via Costura.Fody |
| `MicSpeakerTesterNet35.exe` | .NET Framework 3.5 | Plain WinForms UI, for machines that only have the older Framework installed |

Both require Windows + the matching .NET Framework version (already present on virtually all Windows 7+ machines). No admin rights needed.

## Usage

1. Run the exe.
2. Pick your microphone in the **Microphone** section, click **Start Mic Test** and speak — the level bar should move. Toggle **Monitor mic through speaker** to hear yourself live.
3. Pick your speaker in the **Speaker** section and click **Test Left/Right/Both Channel(s)** to confirm each channel actually plays sound.
4. If the level bar never moves, the app will tell you the likely cause (Windows microphone privacy setting for desktop apps, muted device, wrong device selected).

## Building from source

Requirements: Visual Studio (2022 or newer) with the ".NET desktop development" workload, internet access for the first NuGet restore.

```bash
# Main build (.NET Framework 4.7.2)
msbuild frm_sound_mic_test.csproj /t:Restore
msbuild frm_sound_mic_test.csproj /t:Build /p:Configuration=Release

# Legacy build (.NET Framework 3.5)
msbuild Net35/MicSpeakerTesterNet35.csproj /t:Restore
msbuild Net35/MicSpeakerTesterNet35.csproj /t:Build /p:Configuration=Release
```

Or just open `frm_sound_mic_test.slnx` in Visual Studio and build both projects.

## Project structure

```
Form1.cs / Form1.Designer.cs   Main window (4.7.2 build, Guna.UI2 dark theme)
SupportForm.cs                 "Support this project" dialog shown on exit
Services/                      AudioDeviceService, MicTestService, SpeakerTestService (NAudio) — shared by both builds
Theme.cs                       Color palette used by the main build's UI
Net35/                         Standalone .NET Framework 3.5 build (plain WinForms UI, no Guna.UI2 dependency)
Resources/                     App icon, donation QR codes
```

`Services/*.cs` are linked (not copied) into the `Net35` project, so both builds share the exact same audio logic.

## Tech stack

- WinForms, .NET Framework 4.7.2 (main build) / 3.5 (legacy build)
- [NAudio](https://github.com/naudio/NAudio) for audio capture/playback and device enumeration
- [Guna.UI2.WinForms](https://github.com/Saad-Hosney/guna-2-winforms) for the main build's UI
- [Costura.Fody](https://github.com/Fody/Costura) to merge dependencies into a single exe (main build only — see note below)

> The `Net35` build does **not** use Costura.Fody, since Costura's loader targets `netstandard2.0`, which .NET Framework 3.5 can't load. Instead its one dependency (NAudio.dll) is embedded as a plain resource and resolved at runtime via `AppDomain.AssemblyResolve` (see `Net35/Program.cs`) — a simpler technique that also avoids the antivirus false positives that IL-merging tools (ILRepack/ILMerge) can trigger.

## Support this project

If this tool saved you a trip to a browser-based mic tester, consider supporting development:

- ☕ [Ko-fi](https://ko-fi.com/thanhnguyen150993)
- Momo / Techcombank QR codes shown in the app's exit dialog

Feedback and bug reports: [facebook.com/PycCodeTools](https://www.facebook.com/PycCodeTools)

## License

MIT — see [LICENSE](LICENSE).
