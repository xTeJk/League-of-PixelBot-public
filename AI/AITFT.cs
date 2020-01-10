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
    public class AITFT : AbstractAI
    {
       
        public AITFT(Bot bot, MapPattern pattern) : base(bot, pattern)
        {
        }
        public override void Start()
        {
            //
            Random rnd = new Random();
            int gamestart_move_path = rnd.Next(1, 4);
            int champions_table_path = rnd.Next(1, 3);
            int random_surrender_seconds = rnd.Next(20000, 45000);
            //
            // GAME START >>
            base.Start();
            Console.WriteLine("[TFT] » BOT STARTED!");
            Console.WriteLine("[TFT] » Taking short break to avoid game crash. » 5 seconds");
            Thread.Sleep(5000);
            Interop.Set0x0Position(LeagueConstants.LOL_GAME_PROCESS);
            Thread.Sleep(500);
            Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_START);
            Thread.Sleep(500);
            // GAME START - END >>
            //
            // SELECT CHAR >>
            Thread.Sleep(3000);
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
            // SELECT CHAR - END >>
            //
            //
            // ROUND 1-1 >>
            Console.WriteLine("[TFT] » Waiting 5 seconds for teleport to your arena.");
            Thread.Sleep(5000);
            //
            bool round1_1_planning = true;
            while (round1_1_planning)
            {
                Thread.Sleep(2000);
                var r1_planning = Interop.GetPixelColor(new Point(597, 80));
                if (r1_planning.R == 247 && r1_planning.G == 190 && r1_planning.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 1-1 » Planning...");
                    round1_1_planning = false; // round1-2 planning started!
                }
            }
            //
            Thread.Sleep(5000);
            //
            Bot.LeftClick(PixelsConstants.TFT_ARENA_SELECT_CHAR_1); // 300 537
            Thread.Sleep(1500);
            //
            // ROUND 1-1 >> ARENA >> PUT FIRST CHARACTER >>
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P1);
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 1-2 » First champion is now at map.");
            // ARENA - END >>
            //
            // WAIT FOR ROUND 1-2 >>
            Console.WriteLine("[TFT] » Waiting until 1-1 round end. » 30 seconds");
            Thread.Sleep(30000);
            //
            // ROUND 1-2 >> 
            bool round1_2_planning = true;
            while (round1_2_planning)
            {
                Thread.Sleep(2000);
                var r2_planning = Interop.GetPixelColor(new Point(640, 80));
                if (r2_planning.R == 247 && r2_planning.G == 190 && r2_planning.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 1-2 » Planning...");
                    round1_2_planning = false; // round1-2 planning started!
                }
            }
            //
            Thread.Sleep(2000);
            // ROUND 1-2 >> ARENA >> CHECK FOR ITEMS >>
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
            Console.WriteLine("[TFT] » ROUND 1-2 » Items should be collected.");
            Thread.Sleep(2500);
            //
            // ROUND 1-2 >> ARENA >> BUY CHAMPIONS
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1); // 385 690
                Thread.Sleep(1000);
                Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3); // 520 690
                Thread.Sleep(500);
                Console.WriteLine("[TFT] » ROUND 1-2 » Bought 2 champions.");
            //
            // ROUND 1-2 >> ARENA >> 2ND CHAR AT MAP
            Thread.Sleep(2500);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_SELECT_CHAR_1);
            Thread.Sleep(1500);
            //
            // ROUND 1-2 >> ARENA >> PUT 2ND CHARACTER >>
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P2);
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 1-2 » Second champion is now at map.");
            // ARENA 1-2 - END >>
            //
            /////////////////////////////////
            //
            // WAIT FOR ROUND 1-3 >>
            Console.WriteLine("[TFT] » Waiting until 1-2 round end. » 30 seconds");
            Thread.Sleep(30000);
            //
            // ROUND 1-3 >> 
            bool round1_3_planning = true;
            while (round1_3_planning)
            {
                Thread.Sleep(2500);
                var r3_planning = Interop.GetPixelColor(new Point(685, 80));
                if (r3_planning.R == 247 && r3_planning.G == 190 && r3_planning.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 1-3 » Planning...");
                    round1_3_planning = false; // round1-3 planning started!
                }
            }
            //
            Thread.Sleep(2000);
            // ROUND 1-3 >> ARENA >> CHECK FOR ITEMS >>
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C6); // 850 440
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C5); // 530 320
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C4); // 870 320
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C3); // 870 185
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C2); // 430 235
            Thread.Sleep(1500);
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C1); // 410 415
            //
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 1-3 » Items should be collected.");
            Thread.Sleep(1000);
            //
            // ROUND 1-3 >> ARENA >> BUY CHARACTERS RANDOMLY
            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_4); // 385 690
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 1-3 » Bought 1 champion.");
            //
            // ROUND 1-3 >> ARENA >> 2ND CHAR AT MAP
            Thread.Sleep(2500);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_SELECT_CHAR_2);
            Thread.Sleep(1500);
            //
            // ROUND 1-3 >> ARENA >> PUT 2ND CHARACTER >>
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P3);
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 1-3 » Third champion is now at map.");
            // ARENA 1-3 - ITEMS >>
            //
            Thread.Sleep(1500);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_ITEM_1);
            Thread.Sleep(1000);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P1);
            Thread.Sleep(1500);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_ITEM_2);
            Thread.Sleep(1000);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P3);
            Thread.Sleep(1500);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_ITEM_3);
            Thread.Sleep(1000);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_PLACE_CHAR_P2);
            //
            // ARENA 1-3 - LEVEL UP >>
            Thread.Sleep(1000);
            Bot.LeftClick(PixelsConstants.TFT_ARENA_LVLUP);
            //
            /////////////////////////////////
            //
            // WAIT FOR ROUND 1-3 >>
            Console.WriteLine("[TFT] » Waiting until 1-3 round end. » 30 seconds");
            Thread.Sleep(30000);
            //
            // ROUND 2-1 >> ACTIVITIES LOOP >> WAITING UNTIL 3-1 ROUND TO SURRENDER
            bool round2_1_planning = true;
            while (round2_1_planning)
            {
                Thread.Sleep(2500);
                var r4_planning = Interop.GetPixelColor(new Point(531, 80));
                if (r4_planning.R == 247 && r4_planning.G == 190 && r4_planning.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 2-1 » Planning...");
                    round2_1_planning = false; // round2-1 planning started!
                }
            }
            //
            Thread.Sleep(2000);
            // ROUND 2-1 >> ARENA >> CHECK FOR ITEMS >>
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
            Console.WriteLine("[TFT] » ROUND 2-1 » Items should be collected.");
            Thread.Sleep(500);
            Console.WriteLine("[TFT] » ROUND 2-1 » Looping activities until champions table...");
            Thread.Sleep(2500);
            //
            bool champions_table = true;
            while(champions_table)
            {
                Thread.Sleep(10000);
                var championt_check = Interop.GetPixelColor(new Point(662, 80));
                if (championt_check.R == 247 && championt_check.G == 190 && championt_check.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 2-4 » Champions Table...");
                    champions_table = false; // round2-4 planning started!
                    Thread.Sleep(2000);
                }
                else
                {
                    Random random_ct = new Random();
                    int buy_champion = random_ct.Next(1, 5);
                    int buy_champion_slot = random_ct.Next(1, 5);
                    int levelup = random_ct.Next(1, 5);
                    int refresh = random_ct.Next(1, 3);

                    if(buy_champion == 1)
                    {
                        if (buy_champion_slot == 1)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Randomly bought 1 champion...");
                        }
                        else if(buy_champion_slot == 2)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Randomly bought 2 champions...");
                        }
                        else if (buy_champion_slot == 3)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Randomly bought 3 champions...");
                        }
                        else if(buy_champion_slot == 4)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_4);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Randomly bought 4 champions...");
                        }
                        else if (buy_champion_slot == 5)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_4);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_5);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Randomly bought 5 champions...");
                        }
                    }
                    //
                    Thread.Sleep(1000);
                    //
                    if (levelup == 1)
                    {
                        Bot.LeftClick(PixelsConstants.TFT_ARENA_LVLUP);
                        Thread.Sleep(500);
                        Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Leveled up once...");
                    }
                    //
                    Thread.Sleep(1000);
                    //
                    if (refresh == 1)
                    {
                        Bot.LeftClick(PixelsConstants.TFT_ARENA_REFRESH);
                        Thread.Sleep(500);
                        Console.WriteLine("[TFT] » ROUNDS 2-1 -> 2-4 LOOP » Refreshed shop up once...");
                    }
                }
            }
            //
            Summoner.Move(PixelsConstants.TFT_ARENA_ITEMS_CHECK_MAP_C1); // 410 415
            Console.WriteLine("[TFT] » ROUND 2-4 » Wait for my turn » 15 seconds");
            Thread.Sleep(15000);
            //
            if (champions_table_path == 1)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_CENTER); // 575 410
            }
            else if (champions_table_path == 2)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_LEFT); // 455 315
            }
            else if (champions_table_path == 3)
            {
                Summoner.Move(PixelsConstants.TFT_START_BASEPOINT_CHAR_RIGHT); // 720 315
            }
            //
            // WAIT UNTIL 2-4 PVP ENDS
            Thread.Sleep(60000);
            //
            //LOOPING ROUNDS AND WAITING FOR SURRENDER
            //
            bool surrender = true;
            while (surrender)
            {
                Thread.Sleep(10000);
                var surr = Interop.GetPixelColor(new Point(531, 80));
                if (surr.R == 247 && surr.G == 190 && surr.B == 8)
                {
                    Console.WriteLine("[TFT] » ROUND 3_1 » Time to surrender...");
                    Console.WriteLine("[TFT] » ROUND 3_1 » Bot is going to surrender in " + random_surrender_seconds + " seconds...");
                    surrender = false; // round2-4 planning started!
                    Thread.Sleep(random_surrender_seconds);
                    Keyboard.KeyPress(Keys.Escape);
                    Thread.Sleep(750);
                    Bot.LeftClick(PixelsConstants.TFT_SURRENDER_ESCAPE);
                    Thread.Sleep(1250);
                    Bot.LeftClick(PixelsConstants.TFT_SURRENDER_CONFIRM);
                    Thread.Sleep(5000);
                }
                else
                {
                    Random random_surrender = new Random();
                    int buy_champion_surr = random_surrender.Next(1, 5);
                    int buy_champion_slot_surr = random_surrender.Next(1, 5);
                    int levelup_surr = random_surrender.Next(1, 5);
                    int refresh_surr = random_surrender.Next(1, 3);

                    if (buy_champion_surr == 1)
                    {
                        if (buy_champion_slot_surr == 1)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Randomly bought 1 champion...");
                        }
                        else if (buy_champion_slot_surr == 2)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Randomly bought 2 champions...");
                        }
                        else if (buy_champion_slot_surr == 3)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Randomly bought 3 champions...");
                        }
                        else if (buy_champion_slot_surr == 4)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_4);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Randomly bought 4 champions...");
                        }
                        else if (buy_champion_slot_surr == 5)
                        {
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_1);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_2);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_3);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_4);
                            Thread.Sleep(500);
                            Bot.LeftClick(PixelsConstants.TFT_ARENA_BUY_CHAMP_5);
                            //
                            Thread.Sleep(500);
                            Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Randomly bought 5 champions...");
                        }
                    }
                    //
                    Thread.Sleep(1000);
                    //
                    if (levelup_surr == 1)
                    {
                        Bot.LeftClick(PixelsConstants.TFT_ARENA_LVLUP);
                        Thread.Sleep(500);
                        Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Leveled up once...");
                    }
                    //
                    Thread.Sleep(1000);
                    //
                    if (refresh_surr == 1)
                    {
                        Bot.LeftClick(PixelsConstants.TFT_ARENA_REFRESH);
                        Thread.Sleep(500);
                        Console.WriteLine("[TFT] » ROUNDS 2-4 -> 3-1 LOOP » Refreshed shop up once...");
                    }
                }
            }
            //
            bool game_check = true;
            while (game_check) // end game
            {
                if (!Interop.IsProcessOpen(Pattern.ProcessName))
                {
                    Thread.Sleep(5000);
                    game_check = false;
                    //Pattern.OnProcessClosed();
                    Console.WriteLine("test build");
                    Console.Read();
                }
            }
        }

        private void OnProcessClosed()
        {
        }
        public override void Stop()
        {
        }
    }
}