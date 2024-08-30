using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

            wc = new WebClient();

            wc.DownloadProgressChanged += DownloadProgressChanged;

            var result = buildToDownload.Link.Replace("https://public.simplyblk.xyz/", "");
            var path = Path.Combine(Destination, result);
            wc.DownloadFileAsync(new System.Uri(buildToDownload.Link), path);
        }

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadBar.Value = e.ProgressPercentage;
            downloadLabel.Text = $"{e.ProgressPercentage}%";
        }

        private void DownloadProgressWindow_Load(object sender, EventArgs e)
        {
            downloadLabel.Text = "0%";
        }
    }
}
