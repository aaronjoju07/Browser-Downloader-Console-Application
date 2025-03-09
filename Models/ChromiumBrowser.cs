using System;
using System.Collections.Generic;

namespace BrowserDownloader.Models
{
    /// Chromium Browser implementation inheriting from Browser class.
    class ChromiumBrowser : Browser
    {
        public ChromiumBrowser() : base("Chromium Browser")
        {
            // Adding available versions (same for all operating systems)
            AvailableVersions["136.0.7058.1"] = new Dictionary<string, string>
            {
                { "Common", "https://github.com/chromium/chromium/archive/refs/tags/136.0.7058.1.tar.gz" }
            };

            AvailableVersions["136.0.7058.0"] = new Dictionary<string, string>
            {
                { "Common", "https://github.com/chromium/chromium/archive/refs/tags/136.0.7058.0.tar.gz" }
            };

            AvailableVersions["136.0.7057.1"] = new Dictionary<string, string>
            {
                { "Common", "https://github.com/chromium/chromium/archive/refs/tags/136.0.7057.1.tar.gz" }
            };
        }

        /// <summary>
        /// Displays available Chromium Browser versions.
        /// </summary>
        public override void ShowAvailableVersions()
        {
            Console.WriteLine("Available Chromium Browser versions: " + string.Join(", ", AvailableVersions.Keys));
        }
    }
}