using System;
using System.Collections.Generic;

namespace BrowserDownloader.Models
{
    /// Brave Browser implementation inheriting from Browser class.
    class BraveBrowser : Browser
    {
        public BraveBrowser() : base("Brave Browser")
        {
            // Adding available versions for different operating systems
            AvailableVersions["1.78.27"] = new Dictionary<string, string>
            {
                { "Windows", "https://github.com/brave/brave-browser/releases/download/v1.78.27/brave-browser-nightly-1.78.27-1.x86_64.rpm" },
                { "Linux", "https://github.com/brave/brave-browser/releases/download/v1.78.27/brave-browser-nightly-1.78.27-linux-amd64.zip" },
                { "macOS", "https://github.com/brave/brave-browser/releases/download/v1.78.27/Brave-Browser-Nightly-arm64.dmg" }
            };

            AvailableVersions["1.78.26"] = new Dictionary<string, string>
            {
                { "Windows", "https://github.com/brave/brave-browser/releases/download/v1.78.26/brave-browser-nightly-1.78.26-1.aarch64.rpm" },
                { "Linux", "https://github.com/brave/brave-browser/releases/download/v1.78.26/brave-browser-nightly-1.78.26-linux-amd64.zip" },
                { "macOS", "https://github.com/brave/brave-browser/releases/download/v1.78.26/Brave-Browser-Nightly-arm64.dmg" }
            };
        }

        /// <summary>
        /// Displays available Brave Browser versions.
        /// </summary>
        public override void ShowAvailableVersions()
        {
            Console.WriteLine("Available Brave Browser versions: " + string.Join(", ", AvailableVersions.Keys));
        }
    }
}