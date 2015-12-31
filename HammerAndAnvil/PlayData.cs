using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    [Serializable]
    public class PlayData
    {
        public static PlayData CurrentPlayData
        {
            get; set;
        }
        public string PlayerName
        {
            get; set;
        }
        public string WorkshopName
        {
            get; set;
        }
        public long Gold
        {
            get; set;
        }
        public long Date
        {
            get; set;
        }
        public static void NextDay()
        {
            CurrentPlayData.Date++;
            Console.Clear();
            Console.WriteLine("     {0} 일째...", CurrentPlayData.Date);
            Console.ReadKey(true);
        }
        public PreLoadedScene PreLoadedScene
        {
            get; set;
        }
    }
    public struct PreLoadedScene
    {

    }
}
