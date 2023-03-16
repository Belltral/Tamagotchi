using Tamagotchi.Controller;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = @"./dotnet-install.ps1 -Runtime dotnet -Version 6.0.15";
            process.Start();
            */

            new TamagotchiController().Jogo();
        }
    }
}