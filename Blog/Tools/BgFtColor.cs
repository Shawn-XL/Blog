using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blog.Tools
{

    public class BgFtColor
    {
        [JsonProperty("backgroundColor")]
        public string BackgroudColor { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    internal class ColorStorage
    {
        [JsonProperty("colors")]
        public List<BgFtColor> BgFtColors { get; set; } = new();

        public ColorStorage()
        {
            GetColors();
        }

        private List<BgFtColor> GetColors()
        {
            var BgFtColors = new List<BgFtColor>();
            #region 1 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "231,223,213",
                FontColor = "210,171,171",
                Name = "Eau du Parfum"
            });

            BgFtColors.Add(new()
            {
                BackgroudColor = "168,167,111",
                FontColor = "90,90,79",
                Name = "Kaffir Lime"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "172,114,42",
                FontColor = "163,62,31",
                Name = "Ground Mustard"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "91,110,95",
                FontColor = "74,36,39",
                Name = "Turtle Skin"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "32,64,79",
                FontColor = "201,62,42",
                Name = "Flannel Blanket"
            });
            #endregion

            #region 2 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "213,187,164",
                FontColor = "188,122,79",
                Name = "Cafe au Lait"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "167,156,166",
                FontColor = "168,60,39",
                Name = "Amethyst"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "108,118,50",
                FontColor = "21,50,49",
                Name = "Lichen"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "88,103,68",
                FontColor = "167,151,139",
                Name = "Army Green"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "70,76,83",
                FontColor = "230,220,71",
                Name = "Porpoise"
            });
            #endregion

            #region 3 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "238,206,191",
                FontColor = "237,86,34",
                Name = "Pig's Ear"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "183,116,87",
                FontColor = "179,179,170",
                Name = "Slip"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "108,139,124",
                FontColor = "90,90,80",
                Name = "Eucalyptus"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "183,144,90",
                FontColor = "227,174,38",
                Name = "Butterscotch"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "54,45,38",
                FontColor = "108,117,51",
                Name = "New Purse"
            });
            #endregion

            #region 4 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "230,229,227",
                FontColor = "106,140,124",
                Name = "Winter Kiss"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "178,181,174",
                FontColor = "30,101,133",
                Name = "Almost Sage"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "203,135,73",
                FontColor = "94,90,79",
                Name = "Amaretto"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "25,99,131",
                FontColor = "14,76,71",
                Name = "Montigo"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "33,52,58",
                FontColor = "86,103,65",
                Name = "Deep Water"
            });
            #endregion

            #region 5 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "233,230,213",
                FontColor = "226,174,40",
                Name = "Spring Breeze"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "134,135,140",
                FontColor = "16,51,45",
                Name = "River Stone"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "240,79,51",
                FontColor = "214,234,234",
                Name = "Live Wire"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "53,138,97",
                FontColor = "225,176,35",
                Name = "Kelly Green"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "75,91,78",
                FontColor = "53,177,159",
                Name = "Temperate"
            });
            #endregion

            #region 6 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "243,226,209",
                FontColor = "202,135,72",
                Name = "Seville"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "237,177,143",
                FontColor = "179,117,70",
                Name = "Savannah Pink"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "222,146,39",
                FontColor = "247,227,208",
                Name = "Navel Orange"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "46,67,74",
                FontColor = "125,115,150",
                Name = "Labradorite"
            });
            #endregion

            #region 7 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "251, 205,198",
                FontColor = "167,157,166",
                Name = "Opalescent"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "208,170,170",
                FontColor = "233,233,215",
                Name = "Eighties Mauve"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "165,148,138",
                FontColor = "230,224,212",
                Name = "Ash"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "189,158,137",
                FontColor = "147,90,66",
                Name = "Vintage Twill"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "54,45,38",
                FontColor = "107,116,52",
                Name = "New Purse"
            });
            #endregion

            #region 8 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "233,230,213",
                FontColor = "224,175,33",
                Name = "Spring Breeze"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "155,172,182",
                FontColor = "194,217,242",
                Name = "Chalkdust"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "181,199,198",
                FontColor = "73,88,94",
                Name = "Storm Cloud"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "112,102,89",
                FontColor = "232,208,203",
                Name = "Swiss Chocolate"
            });
            #endregion

            #region 9 Image Done
            BgFtColors.Add(new()
            {
                BackgroudColor = "235,234,227",
                FontColor = "89,89,79",
                Name = "Soft Paper"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "101,187,181",
                FontColor = "187,205,181",
                Name = "Thunderbird"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "232,218,70",
                FontColor = "107,134,86",
                Name = "Lemon"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "000,105,116",
                FontColor = "233,217,75",
                Name = "Peacock"
            });
            BgFtColors.Add(new()
            {
                BackgroudColor = "51,49,50",
                FontColor = "107,133,85",
                Name = "Button Black"
            });
            #endregion

            return BgFtColors;
        }
    }
}
