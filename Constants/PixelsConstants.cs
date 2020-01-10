using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueBot.Constants
{
    public static class PixelsConstants
    {
        public static Point GAME_RESOLUTION = new Point(1280, 720);

        #region Launcher
        public static Point PLAY_BUTTON = new Point(120, 40).Resize(GAME_RESOLUTION);

        public static Point PVP_MBUTTON = new Point(60, 100).Resize(GAME_RESOLUTION);
        public static Point COOP_AGAINST_AI_MBUTTON = new Point(140, 100).Resize(GAME_RESOLUTION);
        public static Point TRAINING_MBUTTON = new Point(245, 100).Resize(GAME_RESOLUTION);

        public static Point COOP_AGAINST_AI_BEGGINER = new Point(350, 520).Resize(GAME_RESOLUTION);
        public static Point COOP_AGAINST_AI_INTERMEDIATE = new Point(360, 520).Resize(GAME_RESOLUTION);
        public static Point PRACTICE_TOOL_BUTTON = new Point(625, 215).Resize(GAME_RESOLUTION);

        public static Point ARAM_BUTTON = new Point(625, 215).Resize(GAME_RESOLUTION);

        public static Point CONFIRM_BUTTON = new Point(540, 690).Resize(GAME_RESOLUTION);
        public static Point ACCEPT_MATCH_BUTTON = new Point(637, 560).Resize(GAME_RESOLUTION);

        public static Point LEAVE_BUTTON = new Point(445, 680).Resize(GAME_RESOLUTION);
        public static Point HONOR_BUTTON = new Point(330, 330).Resize(GAME_RESOLUTION);

        public static Point LEVELUP_BUTTON = new Point(535, 680).Resize(GAME_RESOLUTION);
        #endregion

        #region Champion Select
        public static Point CHAMP1_LOGO = new Point(385, 170).Resize(GAME_RESOLUTION);
        public static Point CHAMP2_LOGO = new Point(690, 170).Resize(GAME_RESOLUTION);
        public static Point LOCK_BUTTON = new Point(630, 610).Resize(GAME_RESOLUTION);

        public static Point CHOOSE_YOUR_LOADOUT_TEXT = new Point(1165, 123).Resize(GAME_RESOLUTION);
        #endregion

        #region Game
        public static Point SUMMONER_1_SLOT = new Point(670, 690).Resize(GAME_RESOLUTION);
        public static Point SUMMONER_2_SLOT = new Point(700, 690).Resize(GAME_RESOLUTION);

        public static Point Q_SLOT = new Point(545, 695).Resize(GAME_RESOLUTION);
        public static Point Z_SLOT = new Point(575, 695).Resize(GAME_RESOLUTION);
        public static Point E_SLOT = new Point(605, 695).Resize(GAME_RESOLUTION);
        public static Point R_SLOT = new Point(635, 695).Resize(GAME_RESOLUTION);

        public static Point UP_Q_SLOT = new Point(545, 665).Resize(GAME_RESOLUTION);
        public static Point UP_Z_SLOT = new Point(575, 665).Resize(GAME_RESOLUTION);
        public static Point UP_E_SLOT = new Point(605, 665).Resize(GAME_RESOLUTION);
        public static Point UP_R_SLOT = new Point(635, 665).Resize(GAME_RESOLUTION);

        public static Point SHOP_BUTTON = new Point(770, 730).Resize(GAME_RESOLUTION);
        public static Point SHOP_ITEM1 = new Point(175, 210).Resize(GAME_RESOLUTION);
        public static Point SHOP_ITEM2 = new Point(230, 210).Resize(GAME_RESOLUTION);

        public static Point LOCK_CAMERA_BUTTON = new Point(1100, 740).Resize(GAME_RESOLUTION);
        public static Point CLOSE_SHOP_BUTTON = new Point(1060, 90).Resize(GAME_RESOLUTION);

        public static Point BACK_BUTTON = new Point(800, 715).Resize(GAME_RESOLUTION);

        public static Point MINIMAP_TOPLEFT_POINT = new Point(1225, 665).Resize(GAME_RESOLUTION); //
        public static Point MINIMAP_BOTTOMRIGHT_POINT = new Point(1330, 775).Resize(GAME_RESOLUTION); //

        public static Point LIFE_BAR_CHECKER_POINT = new Point(731, 391).Resize(GAME_RESOLUTION); // not used
        #endregion
// cale sr
        #region Summoner's Rift
        public static Point BLUESIDE_RED = new Point(1280, 755).Resize(GAME_RESOLUTION);
        public static Point BLUESIDE_WOLFS = new Point(1245, 730).Resize(GAME_RESOLUTION);
        public static Point BLUESIDE_GROMP = new Point(1225, 710).Resize(GAME_RESOLUTION);

        public static Point MIDLANE_MID = new Point(1275, 725).Resize(GAME_RESOLUTION);
        public static Point BOTLANE_BOT = new Point(1320, 780).Resize(GAME_RESOLUTION);

        public static Point BLUESIDE_BOTLANE_T1 = new Point(1310, 785).Resize(GAME_RESOLUTION);
        public static Point REDSITE_BOTLANE_T1 = new Point(1345, 750).Resize(GAME_RESOLUTION);
        #endregion

        #region Howling Abyss
        public static Point HOWLING_ABYSS_MID = new Point(1200, 665).Resize(GAME_RESOLUTION);
        public static Point HOWLING_ABYSS_BLUE_T1 = new Point(1185, 680).Resize(GAME_RESOLUTION);
        public static Point HOWLING_ABYSS_RED_T1 = new Point(1220, 650).Resize(GAME_RESOLUTION);
        public static Point HOWLING_ABYSS_BUSH1 = new Point(1190, 660).Resize(GAME_RESOLUTION);
        public static Point HOWLING_ABYSS_BUSH2 = new Point(1205, 655).Resize(GAME_RESOLUTION);

        public static Point HOWLING_ABYSS_REDNEXUS = new Point(1255, 615).Resize(GAME_RESOLUTION);
        public static Point HOWLING_ABYSS_BLUENEXUS = new Point(1150, 720).Resize(GAME_RESOLUTION);
        #endregion

        #region TFT
        // LAUNCHER
        public static Point TFT_LAUNCHER_PLAY_BUTTON = new Point(125, 40).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_PVP_BUTTON = new Point(60, 100).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_BUTTON = new Point(875, 210).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_NORMAL_BUTTON = new Point(790, 515).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_RANKED_BUTTON = new Point(790, 545).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_CONFIRM = new Point(535, 685).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_FIND_MATCH = new Point(535, 685).Resize(GAME_RESOLUTION);
        public static Point TFT_LAUNCHER_TFT_ACCEPT_MATCH = new Point(637, 560).Resize(GAME_RESOLUTION);
        // GAME START
        public static Point TFT_START_BASEPOINT_START = new Point(580, 465).Resize(GAME_RESOLUTION);
        public static Point TFT_START_BASEPOINT_CHAR_CENTER = new Point(575, 410).Resize(GAME_RESOLUTION);
        public static Point TFT_START_BASEPOINT_CHAR_LEFT = new Point(455, 315).Resize(GAME_RESOLUTION);
        public static Point TFT_START_BASEPOINT_CHAR_RIGHT = new Point(720, 315).Resize(GAME_RESOLUTION);
        // ARENA - BUTTONS
        public static Point TFT_ARENA_LVLUP = new Point(245, 720).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_REFRESH = new Point(245, 670).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_LOCK_SHOP = new Point(245, 620).Resize(GAME_RESOLUTION);
        // ARENA - TABLE ITEMS
        public static Point TFT_ARENA_ITEM_1 = new Point(200, 510).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEM_2 = new Point(225, 490).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEM_3 = new Point(210, 465).Resize(GAME_RESOLUTION);
        // ARENA - SELL CHAMPIONS
        public static Point TFT_ARENA_SELLl_CHAMPION_1 = new Point(295, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_2 = new Point(370, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_3 = new Point(485, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_4 = new Point(570, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_5 = new Point(615, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_6 = new Point(690, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_7 = new Point(815, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_8 = new Point(900, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELLl_CHAMPION_9 = new Point(980, 535).Resize(GAME_RESOLUTION);
        // ARENA - CHECK FOR ITEMS
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C1 = new Point(410, 415).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C2 = new Point(430, 235).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C3 = new Point(870, 185).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C4 = new Point(870, 320).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C5 = new Point(530, 320).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_ITEMS_CHECK_MAP_C6 = new Point(850, 440).Resize(GAME_RESOLUTION);
        // ARENA - BUY CHAMPIONS
        public static Point TFT_ARENA_BUY_CHAMP_1 = new Point(385, 690).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_BUY_CHAMP_2 = new Point(520, 690).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_BUY_CHAMP_3 = new Point(665, 690).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_BUY_CHAMP_4 = new Point(790, 690).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_BUY_CHAMP_5 = new Point(930, 690).Resize(GAME_RESOLUTION);
        // ARENA - CHAMPIONS
        public static Point TFT_ARENA_SELECT_CHAR_1 = new Point(295, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_2 = new Point(370, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_3 = new Point(485, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_4 = new Point(570, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_5 = new Point(615, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_6 = new Point(690, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_7 = new Point(815, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_8 = new Point(900, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_SELECT_CHAR_9 = new Point(980, 535).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_PLACE_CHAR_P1 = new Point(575, 355).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_PLACE_CHAR_P2 = new Point(655, 335).Resize(GAME_RESOLUTION);
        public static Point TFT_ARENA_PLACE_CHAR_P3 = new Point(605, 405).Resize(GAME_RESOLUTION);
        // ARENA - CHECK ROUND
        // ROUND 1
        public static Point TFT_ARENA_CHECK_ROUND_1_1 = new Point(597, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_1_2 = new Point(640, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_1_3 = new Point(685, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        // ROUND 2
        public static Point TFT_ARENA_CHECK_ROUND_2_1 = new Point(531, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_2_2 = new Point(576, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_2_3 = new Point(619, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_2_4 = new Point(662, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8 // ITEMY
        public static Point TFT_ARENA_CHECK_ROUND_2_5 = new Point(706, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_2_6 = new Point(751, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        // ROUND 3
        public static Point TFT_ARENA_CHECK_ROUND_3_1 = new Point(531, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_3_2 = new Point(576, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        public static Point TFT_ARENA_CHECK_ROUND_3_3 = new Point(619, 80).Resize(GAME_RESOLUTION); // 247 / 190 / 8
        // SURRENDER
        public static Point TFT_SURRENDER_ESCAPE = new Point(439, 682).Resize(GAME_RESOLUTION);
        public static Point TFT_SURRENDER_CONFIRM = new Point(570, 445).Resize(GAME_RESOLUTION);
        #endregion

        #region RGC
        public static Point RGC_SERVER_BUTTON = new Point(255, 70).Resize(GAME_RESOLUTION);
        public static Point RGC_SERVER_DROPDOWN = new Point(160, 90).Resize(GAME_RESOLUTION);
        public static Point RGC_SERVER_EUNE = new Point(125, 155).Resize(GAME_RESOLUTION);
        public static Point RGC_SERVER_EUW = new Point(125, 185).Resize(GAME_RESOLUTION);
        public static Point RGC_SERVER_NA = new Point(125, 345).Resize(GAME_RESOLUTION);
        public static Point RGC_SERVER_RU = new Point(125, 445).Resize(GAME_RESOLUTION);
        public static Point RGC_USERNAME_FIELD = new Point(120, 280).Resize(GAME_RESOLUTION);
        public static Point RGC_PASSWORD_FIELD = new Point(120, 345).Resize(GAME_RESOLUTION);
        public static Point RGC_LOGIN_BUTTON = new Point(190, 500).Resize(GAME_RESOLUTION);
        public static Point RGC_LOGIN_ERROR = new Point(250, 320).Resize(GAME_RESOLUTION);
        #endregion



        public static Point Resize(this Point point, Point resolutionScale)
        {
            int xScale = resolutionScale.X / GAME_RESOLUTION.X;
            int YScale = resolutionScale.Y / GAME_RESOLUTION.Y;
            return new Point(point.X * xScale, point.Y * YScale);
        }
    }
}
