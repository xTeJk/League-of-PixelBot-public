using System;
using LeagueBot.Constants;
using LeagueBot.Windows;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace LeagueBot
{
    class Program
    {

        static void Main(string[] args)
        {
            //
            Bot bot = new Bot();
            //
            var AutoLogin = ConfigurationManager.AppSettings["AutoLogin"];
            var RiotGamesClient = ConfigurationManager.AppSettings["RiotGamesClient"];
            var AutoLoginServer = ConfigurationManager.AppSettings["AutoLoginServer"];
            var AutoLoginUser = ConfigurationManager.AppSettings["AutoLoginUser"];
            var AutoLoginPassword = ConfigurationManager.AppSettings["AutoLoginPassword"];
            //
            //// start message
            //
            Console.WriteLine("Press ENTER");
            Console.Read();
            Console.Title = "League of PixelBot - Test Build";
			Console.WriteLine("TEST");
			Console.WriteLine("TEST2");
			Console.WriteLine("TEST3");
			Console.WriteLine("  ");
            // turn on screen feed
            Thread Thread1 = new Thread(Program.ConsoleLog);
            Thread1.Start();
            //
            //
            //// procesy
            //
            Process RGCProcess = new Process();
            Process[] leagueprocess = Process.GetProcessesByName(LeagueConstants.LOL_LAUNCHER_PROCESS);
            Process[] rgcprocess = Process.GetProcessesByName(LeagueConstants.RIOT_LAUNCHER_PROCESS);
            //
            if (leagueprocess.Length == 0 && AutoLogin == "true") // potrzebny fix
            {
                Console.WriteLine("[RGC] » League of Legends process can not be found.");
                Console.WriteLine("[RGC] » AutoLogin is enabled, running up Riot Games Client.");
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("[RGC] » Selected Server: " + AutoLoginServer);
                Console.WriteLine("[RGC] » Account: " + AutoLoginUser);
                Console.WriteLine("");
                Thread.Sleep(1500);
                RGCProcess.StartInfo.UseShellExecute = false;
                RGCProcess.StartInfo.FileName = RiotGamesClient;
                RGCProcess.StartInfo.CreateNoWindow = true;
                RGCProcess.Start();
                Thread.Sleep(1000);
                Console.WriteLine("[RGC] » Riot Games Client started.");
                Console.WriteLine("[RGC] » Taking a short break to let it load. » 30 seconds");
                Thread.Sleep(30000);
                Interop.Set0x0Position(LeagueConstants.RIOT_LAUNCHER_PROCESS);
                Console.WriteLine("");
                Console.WriteLine("[RGC] » Using login details...");
                bot.LeftClick(PixelsConstants.RGC_SERVER_BUTTON);
                Thread.Sleep(1000);
                bot.LeftClick(PixelsConstants.RGC_SERVER_DROPDOWN);
                if (AutoLoginServer == "EUNE")
                {
                    bot.LeftClick(PixelsConstants.RGC_SERVER_EUNE);
                }
                else if (AutoLoginServer == "EUW")
                {
                    bot.LeftClick(PixelsConstants.RGC_SERVER_EUW);
                }
                else if (AutoLoginServer == "NA")
                {
                    bot.LeftClick(PixelsConstants.RGC_SERVER_NA);
                }
                else if (AutoLoginServer == "RU")
                {
                    bot.LeftClick(PixelsConstants.RGC_SERVER_RU);
                }
                Console.WriteLine("[RGC] » Server selected, waiting for login credentials...");
                Thread.Sleep(1500);
                bot.LeftClick(PixelsConstants.RGC_USERNAME_FIELD);
                Thread.Sleep(500);
                SendKeys.SendWait(AutoLoginUser);
                Thread.Sleep(1000);
                bot.LeftClick(PixelsConstants.RGC_PASSWORD_FIELD);
                Thread.Sleep(500);
                SendKeys.SendWait(AutoLoginPassword);
                Thread.Sleep(1000);
                bot.LeftClick(PixelsConstants.RGC_LOGIN_BUTTON);
                Thread.Sleep(5000);
                //
                bot.LeftClick(PixelsConstants.RGC_LOGIN_ERROR);
                var LoginErrorPixel = Interop.GetPixelColor(PixelsConstants.RGC_LOGIN_ERROR);
                if (LoginErrorPixel.R == 249 && LoginErrorPixel.G == 249 && LoginErrorPixel.B == 249)
                {
                    Console.WriteLine("");
                    Console.WriteLine("[RGC] » LOGIN FAILED!");
                    Console.WriteLine("[RGC] » Login details are wrong or choosen league server is down...");
                    Thread.Sleep(10000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("[RGC] » LOGIN SUCCESSFUL!");
                    Console.WriteLine("[RGC] » Waiting to avoid League Launcher load problems or crashes. » 60 seconds");
                    Thread.Sleep(60000);
                    bot.Start(AvailableGameType.TFT);
                }
            }
            else if (leagueprocess.Length == 0 && AutoLogin == "false")
            {
                Console.WriteLine("[RGC] » Game launcher is not turned on!");
                Console.WriteLine("[RGC] » To avoid problems with game crash etc. turn on AutoLogin function.");
            }
            else
            {
                Thread.Sleep(1000);
                bot.Start(AvailableGameType.TFT);
            }
        }

        public static void ConsoleLog(object data)
        {
            ConsoleLog Clog = new ConsoleLog();
            Clog.ShowDialog();
        }
    }
}
