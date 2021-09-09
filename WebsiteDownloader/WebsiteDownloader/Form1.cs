﻿using System;
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
        public List<string> websites = new List<string>()
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
        private WebsiteDataModel DownloadWebsite(string websiteUrl)
        {
            WebsiteDataModel result = new WebsiteDataModel();
            result.WebsiteUrl = websiteUrl;

            WebClient webClient = new WebClient();
            result.WebsiteData = webClient.DownloadString(websiteUrl);
            return result;
        }
        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultBox.Text += $"{data.WebsiteUrl} downloaded: {data.WebsiteData.Length} characters long\n";
        }
        private void RunDownloadSync()
        {
            foreach (var website in websites)
            {
                WebsiteDataModel result = DownloadWebsite(website);
                ReportWebsiteInfo(result);
            }
        }
        private void RunDownloadParallel()
        {
            StringBuilder sb = new StringBuilder();
            Parallel.ForEach(websites, website =>
            {
                WebsiteDataModel result = DownloadWebsite(website);
                sb.AppendLine($"{result.WebsiteUrl} downloaded: {result.WebsiteData.Length} characters long");
            });
            resultBox.Text = sb.ToString();
        }
        private async Task RunDownloadAsync()
        {
            foreach (var website in websites)
            {
                WebsiteDataModel result = await Task.Run(() => DownloadWebsite(website));
                ReportWebsiteInfo(result);
            }
        }
        private async Task RunDownloadParallelAsync()
        {
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();
            foreach (var website in websites)
            {
                tasks.Add(Task.Run(() => DownloadWebsite(website)));
            }

            var results = await Task.WhenAll(tasks);
            foreach(var item in results)
            {
                ReportWebsiteInfo(item);
            }
        }
        private void normalExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            resultBox.Clear();
            sw.Start();
            RunDownloadSync();
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }
        private void normalParallelExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            resultBox.Clear();
            sw.Start();
            RunDownloadParallel();
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }
        private async void asyncExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            resultBox.Clear();
            sw.Start();
            await RunDownloadAsync();
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }
        private async void parallelAsyncExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            resultBox.Clear();
            sw.Start();
            await RunDownloadParallelAsync();
            sw.Stop();
            resultBox.AppendText($"Total execution time: {sw.ElapsedMilliseconds}ms");
        }
    }
}
