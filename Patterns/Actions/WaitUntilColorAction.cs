using LeagueBot.Constants;
using LeagueBot.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeagueBot.Patterns.Actions
{
    public class WaitUntilColorAction : PatternAction
    {
        private Point Point
        {
            get;
            set;
        }
        private Color Color
        {
            get;
            set;
        }

        public WaitUntilColorAction(Point point, Color color, string description, double duration = 0) : base(description, duration)
        {
            this.Point = point;
            this.Color = color;
        }

        public override void Apply(Bot bot, Pattern pattern)
        {
            //
            var GameMode = ConfigurationManager.AppSettings["GameMode"];
            //
            bool valid = false;
            Console.WriteLine("[TFT] » Waiting for game to load...");
            while (!valid)
            {
                if (GameMode == "TFT")
                {
                    var px = Interop.GetPixelColor(new Point(1163, 652));
                    if (px.R == 115 && px.G == 93 && px.B == 49)
                    {
                        Console.WriteLine("[TFT] » Game loaded!");
                        Thread.Sleep(2000);
                        valid = true; // im in game
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    var px = Interop.GetPixelColor(new Point(738, 691));
                    if (px.R == 5 && px.G == 13 && px.B == 11)
                    {
                        Console.WriteLine("      + Game loaded! Waiting 5 seconds to avoid screen freeze crash...");
                        Thread.Sleep(5000);
                        valid = true; // im in game
                    }
                    else
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("      + Waiting 10 seconds for game to load...");
                    }
                }
            }

        }
    }
}
