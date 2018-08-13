using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Url.Downloader.Test
{
    [TestClass]
    public class DownloaderTest
    {
        [TestMethod]
        public void Test1()
        {
            Clipboard.SetText(@"C:\Users\VirtualBox\source\repos\Downloader\Url.Downloader.Test\TestFiles\Files\Scenario001\@.jpg");

            if (Directory.Exists(@"C:\Users\VirtualBox\Desktop\TEMPO"))
                Directory.Delete(@"C:\Users\VirtualBox\Desktop\TEMPO", true);

            var info = Process.Start(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Downloader\bin\Debug\URL Downloader.exe"));

            Thread.Sleep(1000);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = Path.Combine(Environment.CurrentDirectory,@"..\..\TestFiles\Scenarios\Scenario001.rec");
            startInfo.FileName = Path.Combine(Environment.CurrentDirectory, @"..\..\tinytask.exe");
            var test = Process.Start(startInfo);
            info.WaitForExit();
            test.Kill();
            var savedFilesPath = @"C:\Users\VirtualBox\Desktop\TEMPO";
            List<string> files = new List<string>(Directory.GetFiles(savedFilesPath));
          
            for (int cont = 1; cont < files.Count; cont++)
            {
                Assert.IsTrue(files[cont] == Path.Combine(savedFilesPath,$"{cont.ToString("0000")}.jpg"), $"File {cont.ToString("0000")}.jpg was not downloaded." );
            }
            Assert.AreEqual(12, files.Count, "Invalid Number of Files.");
        }
    }
}
