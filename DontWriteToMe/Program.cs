using System;
using System.Net;
using LeagueSharp;
using LeagueSharp.Common;

namespace DontWriteToMe
{
    class Program
    {
        private static readonly string Revision = "1";

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad +=Game_OnGameLoad;
           // CustomEvents.Game.OnGameLoad += Up2Date;
            CustomEvents.Game.OnGameEnd += Game_OnGameEnd;
        }

      //  private static void Up2Date(EventArgs args)
        //{
          //  var wc = new WebClient { Proxy = null  };
            //var gitrevision = wc.DownloadString("https://raw.githubusercontent.com/Adilx05/ChatBan/master/ChatBan%C4%B1mVar/Kontrol.txt");

            //if (Revision != gitrevision)
            //{
              //  Game.PrintChat("<font color=\"#FFFFCC\"><b>A New Version Found Please Update</b></font>");
            //}
        //}

        private static void Game_OnGameLoad(EventArgs args)
        {
            
            Game.Say(RastgeleMetin());

        }

        public static string RastgeleMetin()
        {

            string[] cumleler = new string[5];
            cumleler[0] = "Good luck have fun mates :)";
            cumleler[1] = "GL HF guys lets win :)";
            cumleler[2] = "FUKKK i got chat ban!!!ritoo...pfff gl.";
            cumleler[3] = "Good luck guys";
            cumleler[4] = "pfff i hate all enemy champions.But we can win ahaha xD";

            Random rnd = new Random();
            int rastgele = rnd.Next(0, 4);
            return cumleler[rastgele];
        }

        private static void Game_OnGameEnd(EventArgs args)
        {
            Game.Say("Good game xD");
        }




    }




}
