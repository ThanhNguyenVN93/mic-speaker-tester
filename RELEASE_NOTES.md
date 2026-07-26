# Release Notes

## v1.0.0 — Initial Release

First public release of Mic & Speaker Tester, a portable Windows tool for testing microphones and speakers without needing a browser-based site.

### Features

- **Microphone test**
  - Live VU meter (RMS-based, color-coded green/yellow/red as level rises)
  - Loopback monitoring — hear your mic through your speakers instantly, useful for checking latency and static/noise
  - Auto-detects and marks the current Windows default input device
  - "Refresh" button to re-scan devices after plugging/unplugging hardware
  - On-screen guidance if no audio is detected after starting a test (checks the usual culprits: Windows' "Let desktop apps access your microphone" privacy setting, muted/zero-volume input, wrong device selected)
  - Graceful handling if the active device is unplugged mid-test

- **Speaker test**
  - Play a 440 Hz test tone on the left channel, right channel, or both, to confirm each channel actually outputs sound
  - Volume slider
  - Graceful handling if the active device is unplugged mid-test

- **UI**
  - Dark, purple-accented theme (main build)
  - Feedback link to the project's Facebook page
  - A one-time "Support this project" dialog on exit, with Ko-fi / Momo / Techcombank donation options and a "don't show again" preference

### Two builds, both single-file

- `MicSpeakerTester.exe` — .NET Framework 4.7.2, modern Guna.UI2 dark UI. All dependencies (Guna.UI2, NAudio, Fody/Costura runtime) are merged into the exe via Costura.Fody at build time — nothing else to ship.
- `MicSpeakerTesterNet35.exe` — .NET Framework 3.5, plain WinForms UI, for machines without a modern .NET Framework installed. Its one dependency (NAudio) is embedded as a resource and resolved at runtime, keeping it single-file too, without relying on an IL-merge tool.

### Notes from development

- Costura.Fody was chosen over ILRepack for the main build's single-exe packaging. ILRepack was tried first for the .NET 3.5 build, but its statically-merged output was flagged as a heuristic false positive (`HEUR:Trojan.Win32.Generic`) by Kaspersky — a known friction point with IL-merging tools in general. The .NET 3.5 build instead uses a plain embedded-resource + `AssemblyResolve` approach, which doesn't produce an unusual merged PE and wasn't flagged by anything during testing.
- No admin privileges are required or requested — the app only reads/writes audio devices and a small local preferences file.
