using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace frm_sound_mic_test.Services
{
    public enum TestChannel { Left, Right, Both }

    public class SpeakerTestService : IDisposable
    {
        private const double ToneFrequencyHz = 440.0;

        private WaveOutEvent waveOut;

        public bool IsPlaying { get; private set; }

        // Raised when the device is unplugged/errors mid-playback (playback stops itself)
        public event Action<Exception> OnDeviceError;

        // Plays a sine tone to deviceIndex; channel selects which channel(s) it plays on, volume 0.0-1.0
        public void PlayTestTone(int deviceIndex, TestChannel channel, float volume)
        {
            Stop();

            var signalGenerator = new SignalGenerator(44100, 2)
            {
                Type = SignalGeneratorType.Sin,
                Frequency = ToneFrequencyHz,
                Gain = Clamp01(volume)
            };

            ISampleProvider provider = new ChannelSampleProvider(signalGenerator, channel);

            waveOut = new WaveOutEvent { DeviceNumber = deviceIndex, DesiredLatency = 100 };
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Init(provider);
            waveOut.Play();
            IsPlaying = true;
        }

        public void Stop()
        {
            if (waveOut != null)
            {
                waveOut.PlaybackStopped -= WaveOut_PlaybackStopped;
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            IsPlaying = false;
        }

        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            IsPlaying = false;
            if (e.Exception != null)
            {
                var handler = OnDeviceError;
                if (handler != null)
                {
                    handler(e.Exception);
                }
            }
        }

        private static float Clamp01(float v)
        {
            if (v < 0f) return 0f;
            if (v > 1f) return 1f;
            return v;
        }

        public void Dispose()
        {
            Stop();
        }

        // Keeps the signal on the selected channel, mutes the other one (stereo interleaved buffer: L,R,L,R,...)
        private class ChannelSampleProvider : ISampleProvider
        {
            private readonly ISampleProvider source;
            private readonly TestChannel channel;

            public ChannelSampleProvider(ISampleProvider source, TestChannel channel)
            {
                this.source = source;
                this.channel = channel;
            }

            public WaveFormat WaveFormat
            {
                get { return source.WaveFormat; }
            }

            public int Read(float[] buffer, int offset, int count)
            {
                int samplesRead = source.Read(buffer, offset, count);
                if (channel == TestChannel.Both) return samplesRead;

                for (int i = 0; i + 1 < samplesRead; i += 2)
                {
                    if (channel == TestChannel.Left)
                    {
                        buffer[offset + i + 1] = 0f;
                    }
                    else if (channel == TestChannel.Right)
                    {
                        buffer[offset + i] = 0f;
                    }
                }
                return samplesRead;
            }
        }
    }
}
