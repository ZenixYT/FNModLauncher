using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher.Builds
{
    public partial class DownloadProgressWindow : Form
    {
        private WebClient wc;

        public DownloadProgressWindow(Build buildToDownload, string Destination)
        {
            InitializeComponent();

            this.Text = $"Downloading {buildToDownload.Name}...";

            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);

                var result = buildToDownload.Link.Replace("https://public.simplyblk.xyz/", "");
                var path = Path.Combine(Destination, result);
                client.DownloadFileAsync(new System.Uri(buildToDownload.Link), path);
            });
            thread.Start();
        }

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadBar.Value = e.ProgressPercentage;
            downloadLabel.Text = $"{e.ProgressPercentage}%";

            bytesLabel.Text = $"{Math.Round(e.BytesReceived / 1073741824.0, 2)} GB / {Math.Round(e.TotalBytesToReceive / 1073741824.0, 2)} GB";
        }

        private void DownloadProgressWindow_Load(object sender, EventArgs e)
        {
            downloadLabel.Text = "0%";
        }
    }
}
