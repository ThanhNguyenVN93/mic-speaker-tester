using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace frm_sound_mic_test
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Must be registered before anything that touches NAudio types gets JIT-compiled,
            // which is why the actual app startup is a separate, non-inlined method below.
            AppDomain.CurrentDomain.AssemblyResolve += ResolveEmbeddedAssembly;
            RunApplication();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void RunApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // NAudio.dll is embedded as a plain resource (see MicSpeakerTesterNet35.csproj) instead of
        // IL-merged (ILRepack/Costura), since a merged single PE was flagged as a heuristic false
        // positive by some antivirus engines. A normal assembly carrying an embedded byte resource
        // does not have that problem.
        private static Assembly ResolveEmbeddedAssembly(object sender, ResolveEventArgs args)
        {
            string resourceName = new AssemblyName(args.Name).Name + ".dll";
            var executingAssembly = Assembly.GetExecutingAssembly();
            using (var stream = executingAssembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    return null;
                }
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return Assembly.Load(bytes);
            }
        }
    }
}
