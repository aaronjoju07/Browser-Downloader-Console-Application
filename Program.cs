using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BrowserDownloader.Models;
using BrowserDownloader.Utils;

namespace BrowserDownloader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Detect user OS
            string os = OSHelper.GetOperatingSystem();
            Console.WriteLine($"You are using: {os}\n");

            // List available browsers
            List<Browser> browsers = new List<Browser>
            {
                new ZenBrowser(),
                new BraveBrowser(),
                new ChromiumBrowser()
            };

            // Display choices
            Console.WriteLine("Select a browser to download:");
            for (int i = 0; i < browsers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {browsers[i].Name}");
            }

            Console.Write("Enter your choice (1-3): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= browsers.Count)
            {
                Browser selectedBrowser = browsers[choice - 1];
                selectedBrowser.ShowAvailableVersions();

                Console.Write("Enter the version you want to download: ");
                string version = Console.ReadLine();

                await selectedBrowser.DownloadVersion(version, os);
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
            }
        }
    }
}