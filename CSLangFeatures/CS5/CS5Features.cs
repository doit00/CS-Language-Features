using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace CSLangFeatures.CS5
{
    static class CS5Features
    {
        public static void CallerMemberName()
        {
            //CallerFilePathAttribute Full path of the source file that contains the caller.
            //CallerLineNumberAttribute Line number in the source file at which the method is called.
            //CallerMemberNameAttribute Method or property name of the caller.

            Product bike = new Product() { Name = "Bike", Category = 1 };
            bike.Category = 2;
            bike.Name = "Mountain bike";

        }
        public static void AsyncDemo()
        {
            var client = new WebClient();
            var download = client.DownloadStringTaskAsync("http://www.google.com/robots.txt");
            int i = 0;
            Console.WriteLine("Downloading ");

            while (!download.IsCompleted)
            {
                i++;
                Console.Write(".".PadLeft(i, '.'));
                Thread.Sleep(2);
            }
            Console.WriteLine("\nDownload copleted");
            Console.WriteLine(download.Result.Length);


        }
    }
}