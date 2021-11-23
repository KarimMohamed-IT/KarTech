using KarTech.Seeder;
using System;
using System.IO;

namespace Seeder.Seeder
{
    public static class AutoUpdater
    {
        public static string Autoupdate()
        {
            FileInfo cpuFile = new FileInfo(CommonInformation.CpuFileLocation);
            if ((DateTime.Now - cpuFile.LastWriteTime).TotalDays < 1)
            {
                return $"Files up to date!{Environment.NewLine}Last Updated: {cpuFile.LastWriteTime.ToLongDateString()}";
            }
            Downloader.CPUDownload();
            Downloader.GPUDownload();
            return "Files updated successfully!";
        }
    }
}

