using System;
using System.IO;
using System.Net;

namespace AutoUpdateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("08_dBFT.pdf");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://github.com/NeoResearch/yellowpaper/raw/master/releases/08_dBFT.pdf", "08_dBFT.pdf");
            }
        }
    }
}
