using System;
using System.Collections.Generic;

namespace BrowserDownloader.Models
{
        /// Zen Browser implementation inheriting from Browser class.

    class ZenBrowser : Browser
    {
        public ZenBrowser() : base("Zen Browser")
        {
            // Adding available versions for different operating systems
            AvailableVersions["1.9.20"] = new Dictionary<string, string>
            {
                { "Linux", "https://github.com/zen-browser/desktop/releases/download/1.9b/linux-aarch64.mar" },
                { "Windows", "https://github.com/zen-browser/desktop/releases/download/1.9b/windows-arm64.mar" },
                { "macOS", "https://github.com/zen-browser/desktop/releases/download/1.9b/zen-aarch64.AppImage" }
            };
        }

        public override void ShowAvailableVersions()
        {
            Console.WriteLine("Available Zen Browser versions: " + string.Join(", ", AvailableVersions.Keys));
        }
    }
}