using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher.Utilities
{
    public partial class DownloadProgressWindow : Form
    {
        private WebClient wc;
        private Downloadable thingToDownload;
        private string zipPath;
        private string destination;

        public DownloadProgressWindow(Downloadable thingToDownload, string Destination)
        {
            InitializeComponent();

            this.Text = $"Downloading {thingToDownload.Name}...";

            this.thingToDownload = thingToDownload;
            this.destination = Destination;

            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted);

                Uri uri = new Uri(thingToDownload.Link);

                var result = Path.GetFileName(uri.LocalPath);
                var path = this.zipPath = Path.Combine(Destination, result);
                client.DownloadFileAsync(uri, path);
            });
            thread.Start();
        }

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadBar.Value = e.ProgressPercentage;
            downloadLabel.Text = $"{e.ProgressPercentage}%";

            bytesLabel.Text = $"{Math.Round(e.BytesReceived / 1073741824.0, 2)} GB / {Math.Round(e.TotalBytesToReceive / 1073741824.0, 2)} GB";
        }

        void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                bytesLabel.Hide();

                this.Text = $"Installing {thingToDownload.Name}...";

                if (this.thingToDownload.IsFortniteBuild)
                {
                    if (this.zipPath.EndsWith(".zip"))
                    {
                        using (var archive = ZipArchive.Open(zipPath))
                        {
                            var totalEntries = archive.Entries.Count(entry => !entry.IsDirectory);
                            int currentEntry = 0;

                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(destination, new SharpCompress.Common.ExtractionOptions
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });

                                currentEntry++;
                                int progressPercentage = (int)((double)currentEntry / totalEntries * 100);

                                downloadBar.Value = progressPercentage;
                                downloadLabel.Text = $"{progressPercentage}%";
                            }

                            archive.Dispose();
                        }

                        File.Delete(zipPath);

                        this.Hide();
                    }
                    else if (this.zipPath.EndsWith(".rar"))
                    {
                        using (var archive = RarArchive.Open(zipPath))
                        {
                            var totalEntries = archive.Entries.Count(entry => !entry.IsDirectory);
                            int currentEntry = 0;

                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(destination, new SharpCompress.Common.ExtractionOptions
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });

                                currentEntry++;
                                int progressPercentage = (int)((double)currentEntry / totalEntries * 100);

                                downloadBar.Value = progressPercentage;
                                downloadLabel.Text = $"{progressPercentage}%";
                            }

                            archive.Dispose();
                        }
                        File.Delete(zipPath);

                        this.Hide();
                    }
                }
            }
        }

        private void DownloadProgressWindow_Load(object sender, EventArgs e)
        {
            downloadLabel.Text = "0%";
        }
    }
}
