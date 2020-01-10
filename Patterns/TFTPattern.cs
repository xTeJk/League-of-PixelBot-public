using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueBot.Patterns.Actions;
using LeagueBot.Constants;
using System.Drawing;
using LeagueBot.AI;
using LeagueBot.Windows;

namespace LeagueBot.Patterns
{
    public class TFTPattern : MapPattern
    {
        public TFTPattern(Bot bot) : base(bot)
        {
        }

        public override AbstractAI AI => new AITFT(Bot, this);

        public override Side GetSide()
        {
            return Side.Blue;
        }
    }
}