using LeagueBot.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeagueBot.Patterns.Actions
{
    public class WaitUntilProcessFocusAction : PatternAction
    {
        private string ProcessName
        {
            get;
            set;
        }
        public WaitUntilProcessFocusAction(string processName, string description, double duration = 0) : base(description, duration)
        {
            this.ProcessName = processName;
        }

        public override void Apply(Bot bot, Pattern pattern)
        {
            //
            var GameMode = ConfigurationManager.AppSettings["GameMode"];
            //
            while (!Interop.IsProcessFocused(ProcessName))
            {
                if (GameMode == "TFT")
                {
                    Console.WriteLine("[TFT] » Waiting for a focus from League of Legends... » 10 seconds");
                }
                else
                {
                    Console.WriteLine("[LOL] » Waiting for a focus from League of Legends... » 10 seconds");
                }
                Thread.Sleep(10000);
                try
                {
                    //Interop.BringWindowToFront(ProcessName);
                    Interop.Set0x0Position(ProcessName);
                }
                catch
                {
                }
            }
        }
    }
}
