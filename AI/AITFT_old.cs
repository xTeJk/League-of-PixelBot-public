using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueBot.Patterns;
using System.Threading;
using LeagueBot.Constants;
using LeagueBot.Windows;
using System.Drawing;
using InputManager;
using System.Windows.Forms;

namespace LeagueBot.AI
{
    public class AITFT_old : AbstractAI
    {
       
        public AITFT_old(Bot bot, MapPattern pattern) : base(bot, pattern)
        {
        }
        public override void Start()
        {
            Random rnd = new Random();
            int gamestart_move_path = rnd.Next(1, 4);
            int arena_place_first_char = rnd.Next(1, 4);
            int arena_buy_champs_round2 = rnd.Next(1, 4);

            // gamestart activities
            base.Start();
            Console.WriteLine("[TFT] » BOT STARTED!");
            Thread.Sleep(2000);
            Interop.Set0x0Position(LeagueConstants.LOL_GAME_PROCESS);
            Thread.Sleep(500);
            Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_START); // 580 465
            Thread.Sleep(250);
            //
            // gamestart select char randomly
            if (gamestart_move_path == 1)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_CENTER); // 575 410
            }
            else if (gamestart_move_path == 2)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_LEFT); // 455 315
            }
            else if (gamestart_move_path == 3)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_RIGHT); // 720 315
            }
            //
            Console.WriteLine("[TFT] » Waiting 5 seconds for teleport to your arena.");
            Thread.Sleep(5000); // wait for teleport to your arena
            //
            // your arena activities
            Bot.LeftClick(PixelsConstants.TFT_ARENA_SELECT_CHAR_1); // 300 537
            Thread.Sleep(1000);
            //
            // arena - put selected champ randomly at map
            if (arena_place_first_char == 1)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P1); // 575 355
            }
            else if (arena_place_first_char == 2)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P2); // 655 335
            }
            else if (arena_place_first_char == 3)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P3); // 605 405
            }
            //
            Console.WriteLine("[TFT] » Waiting 40 seconds until first round end.");
            Thread.Sleep(40000); // wait until next round to buy chars
            //
            // arena round 2, walk around map to get items, buy randomly 1-3 champions, place them at map
            // GET ITEMS
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C1); // 410 415
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C2); // 430 235
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C3); // 870 185
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C4); // 870 320
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C5); // 530 320
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C6); // 850 440
            //
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » Items should be collected.");
            //
            // BUY RANDOMLY 1-3 CHAMPIONS
            if (arena_buy_champs_round2 == 1)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1); // 385 690
            }
            else if (arena_buy_champs_round2 == 2)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                Thread.Sleep(500);
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2); // 520 690
            }
            else if (arena_buy_champs_round2 == 3)
            {
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                Thread.Sleep(500);
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                Thread.Sleep(500);
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3); 
            }
            //// 665 690 // char4 = 790 690 // char5 = 930 690
            // arena round 3, lvlup once, wait for next round
            //Bot.LeftClick(PixelsConstants.TFT_ARENA_LVLUP); // 245 720 // refresh = 245 670
            //
            // sell char place 1 = 295 530
            // sell char place 2 = 370 535
            // sell char place 3 = 485 535
            // sell char place 4 = 570 535
            // sell char place 5 = 615 535
            // sell char place 6 = 690 535
            // sell char place 7 = 815 535
            // sell char place 8 = 900 535
            // sell char place 9 = 980 535
            //
            // lock shop = 245 620
            //
            // item 1 = 200 510
            // item 2 = 225 490
            // item 3 = 210 465
            //

            //bool playing = true;
            //
            //while (playing)
            //{
            //    if (!Interop.IsProcessOpen(Pattern.ProcessName))
            //    {
            //        playing = false;
            //        Pattern.OnProcessClosed();
            //    }
            //    else
            //    {
            //        if (Side == Side.Blue)
            //            Summoner.Move(PixelsConstants.HOWLING_ABYSS_BLUE_T1);
            //        else
            //            Summoner.Move(PixelsConstants.HOWLING_ABYSS_RED_T1);
            //        Thread.Sleep(2000);
            //
            //		// dodac randomizacje punktow do rzucania skilli
            //        Point blueSideAim = new Point(1085, 431);
            //        Point redSideAim = new Point(790, 590);
            //		//
            //
            //        Point target = Side == Side.Blue ? blueSideAim : redSideAim;
            //
            //        Summoner.Q();
            //        Thread.Sleep(500);
            //        Mouse.Move(target.X, target.Y);
            //        Summoner.E();
            //        Thread.Sleep(500);
            //        Mouse.Move(target.X, target.Y);
            //        Summoner.Z();
            //        Thread.Sleep(500);
            //        Mouse.Move(target.X, target.Y);
            //        Summoner.R();
            //
            //        if (Side ==  Side.Blue)
            //            Summoner.Move(PixelsConstants.HOWLING_ABYSS_REDNEXUS);
            //        else
            //            Summoner.Move(PixelsConstants.HOWLING_ABYSS_BLUENEXUS);
            //
            //        Thread.Sleep(3000);
            //        AsyncRandom rd = new AsyncRandom();
            //        int shiftX = rd.Next(-3, 3);
            //        int shiftY = rd.Next(-3, 3);
            //        var closeRandomPt = new Point(Summoner.Position.X + shiftX, Summoner.Position.Y + shiftY);
            //        Bot.RightClick(closeRandomPt);
            //        Thread.Sleep(1000);
            //        Summoner.Summoner1();
            //        Summoner.Summoner2();
            //
            //    }
            //}
        }
        private void OnProcessClosed()
        {

        }
        public override void Stop()
        {
        }
    }
}