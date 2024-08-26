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

namespace FNModLauncher
{
    internal class Launcher
    {
        private readonly string _buildPath;
        private readonly string _username;

        private Process _fnEacShippingProcess = null;
        private Process _fnLauncherProcess = null;
        private Process _fnShippingProcess = null;

        public Launcher(string buildPath, string username)
        {
            this._buildPath = buildPath;
            this._username = username;
        }

        public void Launch(bool bServer = false, bool bUseProxy = false, bool bUseMods = false)
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

            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ".RizzLauncher");
            string dllPath = Path.Combine(appDataPath, "dll");
            if (!Directory.Exists(appDataPath) && !Directory.Exists(dllPath))
            {
                Directory.CreateDirectory(appDataPath);
                Directory.CreateDirectory(dllPath);

                Utilities.Download[] filesToDownload =
                {
                    new Utilities.Download("Cobalt.dll", "https://dl.dropboxusercontent.com/scl/fi/60wzq32la5x6j952qkieu/Cobalt.dll?rlkey=qvpu54tt13p0p71c8z9wd7qp3&st=2poe6fln&dl=0"),
                    new Utilities.Download("Reboot.dll", "https://dl.dropboxusercontent.com/scl/fi/0zt9bdc75mpm8l0yncvqe/Reboot.dll?rlkey=f2msvs1td12ouwulgnw3abbkn&st=l9i7frby&dl=0")
                };

                foreach (Utilities.Download file in filesToDownload)
                {
                    var destPath = Path.Combine(dllPath, file.Name);
                    Utilities.Downloader.Download(file.Url, destPath);
                }

                string thingy = bServer ? "Server" : "Client";
                MessageBox.Show($"Downloaded required DLLs!\nClick 'Launch {thingy}' again!");

                return;
            }

            //List<Mod> mods = ModLoader.GetMods(this._buildPath);

            var launchArgs = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -NOSSLPINNING -nobe -fromfl=eac -fltoken=7a848a93a74ba68876c36C1c -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_TYPE=epic -AUTH_LOGIN={_username} -AUTH_PASSWORD=awesomesauce";

            var BinariesPath = Path.Combine(this._buildPath, "FortniteGame\\Binaries\\Win64\\");

            var fnEacShippingPath = Path.Combine(BinariesPath, "FortniteClient-Win64-Shipping_EAC.exe");
            var fnLauncherPath = Path.Combine(BinariesPath, "FortniteLauncher.exe");
            var fnShippingPath = Path.Combine(BinariesPath, "FortniteClient-Win64-Shipping.exe");

            /*
            if (bUseMods)
            {
                if (mods.Count > 0)
                {
                    ModLoader.ApplyPakMods(this._buildPath, mods);
                }
            }*/

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

            //if (!bUseProxy)
            //    Injector.Inject(Path.Combine(dllPath, "Cobalt.dll"), _fnShippingProcess.Id

            //if (bUseMods)
            //{
            //    if (mods.Count != 0)
            //    {
            //        if (!bServer)
            //        {
            //            Thread.Sleep(20000);
            //            ModLoader.ApplyDLLMods(this._buildPath, _fnShippingProcess.Id, mods);
            //        }
            //    }
            //}

            _fnShippingProcess.WaitForExit();
            if (_fnLauncherProcess != null) _fnLauncherProcess.Kill();
            if (_fnEacShippingProcess != null) _fnEacShippingProcess.Kill();

            //if (bUseMods)
            //    ModLoader.RemoveMods(this._buildPath, mods);
        }

        public async void Exit()
        {
            if (_fnShippingProcess != null)
                _fnShippingProcess.Kill();
        }
    }
}