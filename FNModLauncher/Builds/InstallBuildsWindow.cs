using FNModLauncher.Builds;
using FNModLauncher.Utilities;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace FNModLauncher.Builds
{
    public partial class InstallBuildsWindow : Form
    {
        List<Downloadable> builds;
        string SelectedBuildName = string.Empty;

        public InstallBuildsWindow()
        {
            InitializeComponent();

            builds = new List<Downloadable>();
        }

        private async void InstallBuildsWindow_Load(object sender, EventArgs e)
        {
            string url = "https://github.com/simplyblk/Fortnitebuilds";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync(url);
                res.EnsureSuccessStatusCode();

                string content = await res.Content.ReadAsStringAsync();

                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(content);

                foreach (HtmlNode links in document.DocumentNode.SelectNodes("//a[@href]"))
                {
                    string href = links.GetAttributeValue("href", string.Empty);

                    if (href.StartsWith("https://public.simplyblk.xyz/"))
                    {
                        Downloadable newBuild = new Downloadable();
                        newBuild.Link = href;
                        string Version = href.Replace("https://public.simplyblk.xyz/", "").Replace(".zip", "").Replace(".rar", "");
                        newBuild.Name = $"Fortnite v{Version}";
                        newBuild.IsFortniteBuild = true;

                        builds.Add(newBuild);
                    }
                }
            }

            foreach (Downloadable build in builds)
                buildsBox.Items.Add(build.Name);
        }

        private void buildsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBuildName = buildsBox.SelectedItem.ToString();
        }

        private void installPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                installPathBox.Text = diag.SelectedPath;
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            Downloadable selectedBuild = null;
            foreach (var build in builds)
            {
                if (build.Name == SelectedBuildName)
                {
                    selectedBuild = build;
                    break;
                }
            }

            if (selectedBuild != null)
            {
                DownloadProgressWindow progressWindow = new DownloadProgressWindow(selectedBuild, installPathBox.Text);
                progressWindow.Show();

                this.Close();
            }
        }
    }
}
