using System;
using System.Runtime.InteropServices;

namespace BrowserDownloader.Utils
{
    /// Utility class for detecting the user's operating system.
    class OSHelper
    {
        public static string GetOperatingSystem()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "Windows";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "Linux";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return "macOS";
            else
                return "Unknown OS";
        }
    }
}   