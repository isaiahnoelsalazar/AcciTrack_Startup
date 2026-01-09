using CSSimpleFunctions;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace AcciTrack_Startup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("resources"))
            {
                SimpleFileHandler.ProjectToLocation(Assembly.GetExecutingAssembly(), "AcciTrack_Build.zip");
                ZipFile.ExtractToDirectory("AcciTrack_Build.zip", "resources");
                File.Delete("AcciTrack_Build.zip");
            }
            ProcessStartInfo run0 = new ProcessStartInfo();
            run0.WorkingDirectory = "resources";
            run0.FileName = "resources\\AcciTrack_Build.exe";
            run0.UseShellExecute = false;
            run0.RedirectStandardOutput = true;
            run0.CreateNoWindow = true;
            Process.Start(run0);
        }
    }
}
