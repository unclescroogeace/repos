using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteDownloader
{
    public partial class AsyncExample : Form
    {


        public AsyncExample()
        {
            InitializeComponent();

        }

        public static List<string> websites = new List<string>()
        {
            "https://www.google.com",
            "https://www.microsoft.com",
            "https://www.cnn.com",
            "https://www.amazon.com",
            "https://www.facebook.com",
            "https://www.twitter.com",
            "https://www.codeproject.com",
            "https://www.stackoverflow.com",
            "https://en.wikipedia.org/wiki/.NET_Framework",
            "https://nakov.com",
            "https://elmah.io",
            "https://www.pluralsight.com",
            "https://www.udemy.com"
        };

        public class WebsiteDataModel
        {
            public string WebsiteUrl { get; set; }
            public string WebsiteData { get; set; }
        }

        private static WebsiteDataModel DownloadWebsite(string websiteUrl)
        {
            WebsiteDataModel result = new WebsiteDataModel();
            result.WebsiteUrl = websiteUrl;

            WebClient webClient = new WebClient();
            result.WebsiteData = webClient.DownloadString(websiteUrl);
            return result;
        }

        private async static Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteUrl)
        {
            return await Task.Factory.StartNew(() =>
            {
                WebsiteDataModel result = new WebsiteDataModel();
                result.WebsiteUrl = websiteUrl;

                WebClient webClient = new WebClient();
                result.WebsiteData = webClient.DownloadString(websiteUrl);
                return result;
            });
        }

        private void normalExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            resultBox.Clear();
            sw.Start();
            foreach (var site in websites)
            {
                resultBox.AppendText($"{site} downloaded: {DownloadWebsite(site).WebsiteData.Length} characters long\n");
            }
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }

        private void normalParallelExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            resultBox.Clear();
            sw.Start();
            Parallel.ForEach(websites, website =>
            {
                resultBox.AppendText($"{website} downloaded: {DownloadWebsite(website).WebsiteData.Length} characters long\n");
            });
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }

        private void asyncExecute_Click(object sender, EventArgs e)
        {

        }
    }
}
