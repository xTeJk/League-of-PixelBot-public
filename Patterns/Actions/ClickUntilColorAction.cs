using InputManager;
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
    public class ClickUntilColorAction : PatternAction
    {
        Color Color
        {
            get;
            set;
        }
        Point Point
        {
            get;
            set;
        }
        Point ClickPoint
        {
            get;
            set;
        }
        public ClickUntilColorAction(Color color, Point point, Point clickPoint, string description, double duration = 0) : base(description, duration)
        {
            ClickPoint = clickPoint;
            Point = point;
            Color = color;
        }

        public override void Apply(Bot bot, Pattern pattern)
        {
            //
            var GameMode = ConfigurationManager.AppSettings["GameMode"];
            //
            bool valid = false;
            while (!valid)
            {
                //pattern.BringProcessToFront();
                //pattern.CenterProcessMainWindow();
                pattern.Set0x0Position();
                var px = Interop.GetPixelColor(new Point(637, 560));
                if (px.R == 66 && px.G == 116 && px.B == 133)
                {
                    if (GameMode == "TFT")
                    {
                        Console.WriteLine("[TFT] » Waiting for a matchmaking screen to accept game... » 5 seconds");
                    }
                    else
                    {
                        Console.WriteLine("[LOL] » Waiting for a matchmaking screen to accept game... » 5 seconds");
                    }
                    Thread.Sleep(5000);
                    valid = true; // im in game
                }
                else
                {
                    Thread.Sleep(1000);
                    Mouse.Move(637, 560);
                    Mouse.PressButton(Mouse.MouseKeys.Left, 150);
                }
            }
        }
    }
}
