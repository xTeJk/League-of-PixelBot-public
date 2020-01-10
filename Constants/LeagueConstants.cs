using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueBot.Constants
{
    public static class LeagueConstants
    {
        public const string LOL_VERSION = "9.21"; 

        public const string LOL_LAUNCHER_PROCESS = "LeagueClientUx";
        public const string RIOT_LAUNCHER_PROCESS = "RiotClientUx";
        public const string LOL_GAME_PROCESS = "League of Legends";
     
    }
    public enum Lane
    {
        TOP,
        MID,
        BOT,
    }
    public enum LaneStructuresEnum
    {
        T1,
        T2,
        T3,
        Inibitor,
    }
    public enum Side
    {
        Blue,
        Red,
    }
}
