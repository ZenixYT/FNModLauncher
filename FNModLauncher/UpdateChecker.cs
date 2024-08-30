using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Octokit;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher
{
    public class UpdateChecker
    {
        private string VersionTag = "1.0.0";
        private GitHubClient client;
        private MainWindow mainWindow;

        public UpdateChecker(MainWindow mainWindow)
        {
            client = new GitHubClient(new ProductHeaderValue("FNModLauncher"));
            this.mainWindow = mainWindow;
        }

        public async Task<Release> GetLatestRelease()
        {
            try
            {
                var release = await client.Repository.Release.GetLatest("ZenixYT", "FNModLauncher");

                return release;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async void CheckForUpdate()
        {
            var release = await GetLatestRelease();

            if (release != null)
            {
                if (release.Name != VersionTag)
                {
                    DialogResult res = MessageBox.Show($"There is a new update available! ({release.Name})\n\nDo you want to download it now?", "FNModLauncher", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        var asset = release.Assets.FirstOrDefault(a => a.Name == "FMLSetup.exe");

                        string LADPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ".FNModLauncher");
                        if (!Directory.Exists(LADPath))
                            Directory.CreateDirectory(LADPath);

                        string tempPath = Path.Combine(LADPath, ".temp");
                        if (!Directory.Exists(tempPath))
                            Directory.CreateDirectory(tempPath);

                        string filePath = Path.Combine(tempPath, "FMLSetup.exe");

                        using (var httpClient = new HttpClient())
                        {
                            var stream = await httpClient.GetStreamAsync(asset.BrowserDownloadUrl);
                            using (var fileStream = new FileStream(filePath, System.IO.FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                await stream.CopyToAsync(fileStream);
                            }
                        }

                        // Launch the downloaded file
                        Process.Start(filePath);

                        mainWindow.Close();
                    }
                }
            }
        }
    }
}
