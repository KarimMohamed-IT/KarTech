using System;
using System.Net;

namespace KarTech.Seeder
{
    public static class Downloader 
    {
        public static void CPUDownload()
        {
            Console.WriteLine("Downloading Cpu List...");
            using (var client = new WebClient())
            {
                client.DownloadFile(new Uri(CommonInformation.CpuUrl), CommonInformation.CpuFileLocation);
                
            }
            Console.WriteLine("Cpu download is done.");
        }


        public static void GPUDownload()
        {
            Console.WriteLine("Downloading Gpu List...");
            using (var client = new WebClient())
            {
                client.DownloadFile(new Uri(CommonInformation.GpuUrl),CommonInformation.GpuFileLocation);

            }
            Console.WriteLine("Gpu download is done.");
        }
    }
}
