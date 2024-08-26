using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FNModLauncher.Utilities
{
    public struct Download
    {
        public string Name;
        public string Url;

        public Download(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }

    public static class Downloader
    {
        public async static void Download(string url, string path)
        {
            using (HttpClient client = new HttpClient())
            {
                string destinationPath = path;

                HttpResponseMessage res = await client.GetAsync(url);
                res.EnsureSuccessStatusCode();

                using (FileStream fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await res.Content.CopyToAsync(fs);
                }
            }
        }
    }
}
