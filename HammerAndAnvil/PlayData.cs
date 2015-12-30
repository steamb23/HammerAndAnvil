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
        public bool IsTutorialComplete
        {
            get; set;
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
