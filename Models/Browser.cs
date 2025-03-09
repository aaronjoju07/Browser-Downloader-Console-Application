using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BrowserDownloader.Services;

namespace BrowserDownloader.Models
{
    /// Abstract base class for all browsers.
    /// It defines common properties and methods for downloading versions.
    abstract class Browser
    {
        public string Name { get; protected set; }  // Browser name
        protected Dictionary<string, Dictionary<string, string>> AvailableVersions;

        public Browser(string name)
        {
            Name = name;
            AvailableVersions = new Dictionary<string, Dictionary<string, string>>();
        }

        /// Display available versions of the browser.
        public abstract void ShowAvailableVersions();

        /// Check if a given version exists for download.
        public bool IsVersionAvailable(string version)
        {
            return AvailableVersions.ContainsKey(version);
        }

        /// Download a specific version for the given OS.
        public async Task DownloadVersion(string version, string os)
        {
            if (IsVersionAvailable(version) && AvailableVersions[version].ContainsKey(os))
            {
                string downloadUrl = AvailableVersions[version][os];
                string fileExtension = Path.GetExtension(downloadUrl);
                Console.WriteLine($"file ext : {fileExtension}");
                Console.WriteLine($"Downloading {Name} version {version}...");
                string versionWithHyphen = version.Replace('.', '-');
                await FileDownloader.DownloadFileWithProgress(downloadUrl, $"{Name}-{versionWithHyphen}{fileExtension}");
            }
            else
            {
                Console.WriteLine($"Version {version} of {Name} is not available for {os}.");
            }
        }
    }
}