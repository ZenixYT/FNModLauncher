using FNModLauncher.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// stolen from Londiuh (heavily modded, thank you)
namespace FNModLauncher
{
    internal class Launcher
    {
        private readonly string _buildPath;

        private Process _fnEacShippingProcess = null;
        private Process _fnLauncherProcess = null;
        private Process _fnShippingProcess = null;

        public Launcher(string buildPath)
        {
            this._buildPath = buildPath;
        }

        public void Launch(string modPath, string additionalArgs = "")
        {
            string[] foldersToCheckFor = { "FortniteGame", "Engine" };
            foreach (string folder in foldersToCheckFor)
            {
                string folderPath = Path.Combine(this._buildPath, folder);
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show($"You have the wrong Fortnite folder. It must have FortniteGame and Engine folders inside of it. {folderPath}");
                    return;
                }
            }

            var launchArgs = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -NOSSLPINNING -nobe -fromfl=eac -fltoken=7a848a93a74ba68876c36C1c -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ {additionalArgs}";

            var BinariesPath = Path.Combine(this._buildPath, "FortniteGame\\Binaries\\Win64\\");

            var fnEacShippingPath = Path.Combine(BinariesPath, "FortniteClient-Win64-Shipping_EAC.exe");
            var fnLauncherPath = Path.Combine(BinariesPath, "FortniteLauncher.exe");
            var fnShippingPath = Path.Combine(BinariesPath, "FortniteClient-Win64-Shipping.exe");

            ModLoader modLoader = new ModLoader(modPath, this._buildPath);
            List<Mod> mods = modLoader.FetchMods();

            if (mods.Count > 0)
                modLoader.ApplyPakMods(mods);

            if (File.Exists(fnLauncherPath))
            {
                _fnLauncherProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = fnLauncherPath,
                        UseShellExecute = false,
                        Arguments = launchArgs
                    }
                };

                _fnLauncherProcess.Start();
                foreach (ProcessThread thread in _fnLauncherProcess.Threads)
                {
                    Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                }
            }

            if (File.Exists(fnEacShippingPath))
            {
                _fnEacShippingProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = fnEacShippingPath,
                        UseShellExecute = false,
                        Arguments = launchArgs
                    }
                };

                _fnEacShippingProcess.Start();
                foreach (ProcessThread thread in _fnEacShippingProcess.Threads)
                {
                    Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                }
            }

            _fnShippingProcess = new Process
            {
                StartInfo =
                {
                    FileName = fnShippingPath,
                    Arguments = launchArgs,
                    UseShellExecute = false
                }
            };
            _fnShippingProcess.Start();

            modLoader.ApplyDLLMods(mods, _fnShippingProcess.Id);

            _fnShippingProcess.WaitForExit();
            if (_fnLauncherProcess != null) _fnLauncherProcess.Kill();
            if (_fnEacShippingProcess != null) _fnEacShippingProcess.Kill();

            modLoader.RemovePakMods(mods);
        }

        public async void Exit()
        {
            if (_fnShippingProcess != null)
                _fnShippingProcess.Kill();
        }
    }
}