using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Scenes.Places
{
    class Home : PlaceScene
    {
        public override string PlaceName
        {
            get
            {
                return PlayData.CurrentPlayData.WorkshopName;
            }
        }

        public override void Script()
        {
            Console.Write("소지금 : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0:N0}",PlayData.CurrentPlayData.Gold);
            Console.ResetColor();
            Console.Write(" 파울");
        }
    }
}
