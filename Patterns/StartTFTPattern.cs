using LeagueBot.Constants;
using LeagueBot.Patterns.Actions;
using System;
using System.Threading;
using System.Diagnostics;
using LeagueBot.Windows;
using System.Configuration;

namespace LeagueBot.Patterns
{
    public class StartTFTPattern : Pattern
    {
        public override string ProcessName => LeagueConstants.LOL_LAUNCHER_PROCESS;

        public override PatternAction[] Actions => new PatternAction[]
        {
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_PLAY_BUTTON,"[TFT] » Press PLAY Button",1),
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_PVP_BUTTON,"[TFT] » Press PVP Button",1.5),
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_TFT_BUTTON,"[TFT] » Press TFT Button",1.5),
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_TFT_NORMAL_BUTTON,"[TFT] » Press TFT NORMAL Button",1),
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_TFT_CONFIRM,"[TFT] » Press CONFIRM Button",3),
            new ClickAction(ClickType.LEFT,PixelsConstants.TFT_LAUNCHER_TFT_FIND_MATCH,"[TFT] » Press FIND MATCH Button",3),
            new ClickUntilColorAction(ColorConstants.CHOOSE_YOUR_LOADOUT_COLOR,PixelsConstants.CHOOSE_YOUR_LOADOUT_TEXT,PixelsConstants.TFT_LAUNCHER_TFT_ACCEPT_MATCH,"[TFT] » Looking for a game...",2),
            new WaitUntilProcessOpenAction(LeagueConstants.LOL_GAME_PROCESS,"[TFT] » Waiting for League of Legends process...",120,new Action(() => {  Bot.ApplyPattern(new StartTFTPattern(Bot), 4); })), // timeout = if someone, leave the game before it start.
            new DefinePatternAction(new TFTPattern(Bot),"[TFT] » Executing IN GAME Pattern",0),
        };

        public StartTFTPattern(Bot bot) : base(bot)
        {
        }



        public override void OnProcessClosed()
        {

        }
    }
}
