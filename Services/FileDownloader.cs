using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrowserDownloader.Services
{
    /// Handles downloading files with a progress bar.
    class FileDownloader
    {
        public static async Task DownloadFileWithProgress(string url, string filename)
        {
            try
            {
                using HttpClient client = new HttpClient();
                string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string filePath = Path.Combine(downloadsFolder, filename);

                using HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                long? totalBytes = response.Content.Headers.ContentLength;
                using Stream contentStream = await response.Content.ReadAsStreamAsync();
                using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);

                byte[] buffer = new byte[8192];
                long totalRead = 0;
                int bytesRead;

                Console.WriteLine("Downloading...");
                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                    totalRead += bytesRead;
                    
                    if (totalBytes.HasValue)
                    {
                        double percentage = (double)totalRead / totalBytes.Value * 100;
                        Console.Write($"\rProgress: {percentage:F2}%");
                    }
                }

                Console.WriteLine($"\nDownload completed: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError downloading file: {ex.Message}");
            }
        }
    }
}   