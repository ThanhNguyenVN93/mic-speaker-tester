using System;
using NAudio.Wave;

namespace frm_sound_mic_test.Services
{
    public class MicTestService : IDisposable
    {
        private WaveInEvent waveIn;
        private BufferedWaveProvider bufferedProvider;
        private WaveOutEvent waveOut;

        public bool IsCapturing { get; private set; }
        public bool IsMonitoring { get; private set; }

        // Current level (0-100) to drive the VU meter
        public event Action<int> OnLevelChanged;

        // Raised when the device is unplugged/errors mid-capture (capture stops itself)
        public event Action<Exception> OnDeviceError;

        public void StartCapture(int deviceIndex)
        {
            StopCapture();

            waveIn = new WaveInEvent
            {
                DeviceNumber = deviceIndex,
                WaveFormat = new WaveFormat(44100, 16, 1),
                BufferMilliseconds = 50
            };
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.RecordingStopped += WaveIn_RecordingStopped;

            bufferedProvider = new BufferedWaveProvider(waveIn.WaveFormat)
            {
                DiscardOnBufferOverflow = true,
                BufferDuration = TimeSpan.FromSeconds(2)
            };

            waveIn.StartRecording();
            IsCapturing = true;
        }

        public void StopCapture()
        {
            SetMonitoring(false, -1);

            if (waveIn != null)
            {
                waveIn.DataAvailable -= WaveIn_DataAvailable;
                waveIn.RecordingStopped -= WaveIn_RecordingStopped;
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }
            bufferedProvider = null;
            IsCapturing = false;
        }

        // Route mic audio straight to the speaker (loopback) to test latency / rattle
        public void SetMonitoring(bool enabled, int outputDeviceIndex)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            IsMonitoring = false;

            if (enabled && IsCapturing && bufferedProvider != null)
            {
                waveOut = new WaveOutEvent { DeviceNumber = outputDeviceIndex, DesiredLatency = 100 };
                waveOut.Init(bufferedProvider);
                waveOut.Play();
                IsMonitoring = true;
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (IsMonitoring && bufferedProvider != null)
            {
                bufferedProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }

            var handler = OnLevelChanged;
            if (handler != null)
            {
                handler(CalculateLevel(e.Buffer, e.BytesRecorded));
            }
        }

        // Compute RMS over the 16-bit PCM mono buffer and scale it to 0-100.
        // Multiplied by a gain factor since normal speech RMS is much lower than full-scale.
        private const double LevelGain = 4.0;

        private int CalculateLevel(byte[] buffer, int bytesRecorded)
        {
            if (bytesRecorded < 2) return 0;

            double sumSquares = 0;
            int sampleCount = 0;
            for (int i = 0; i + 1 < bytesRecorded; i += 2)
            {
                short sample = (short)(buffer[i] | (buffer[i + 1] << 8));
                double normalized = sample / 32768.0;
                sumSquares += normalized * normalized;
                sampleCount++;
            }
            if (sampleCount == 0) return 0;

            double rms = Math.Sqrt(sumSquares / sampleCount);
            int level = (int)(rms * 100 * LevelGain);
            return Math.Max(0, Math.Min(100, level));
        }

        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception != null)
            {
                IsCapturing = false;
                SetMonitoring(false, -1);

                var handler = OnDeviceError;
                if (handler != null)
                {
                    handler(e.Exception);
                }
            }
        }

        public void Dispose()
        {
            StopCapture();
        }
    }
}
