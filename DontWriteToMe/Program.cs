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
            cumleler[0] = "I Have Chat Ban Can't Write";
            cumleler[1] = "If I Write In Game I Will Confused So I Can't Write In Game";
            cumleler[2] = "Rito Has Give A Chat Ban For Me So I Can't Write In Game";
            cumleler[3] = "Please Play Carefully Don't Write To Each Other";
            cumleler[4] = "I Have Some Ping If I Play Bad Please Excuse Me";

            Random rnd = new Random();
            int rastgele = rnd.Next(0, 4);
            return cumleler[rastgele];
        }

        private static void Game_OnGameEnd(EventArgs args)
        {
            Game.Say("GG");
        }




    }




}
