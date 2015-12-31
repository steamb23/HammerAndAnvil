using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Scenes
{
    abstract class PlaceScene : IScene
    {
        public abstract string PlaceName
        {
            get;
        }
        public void Run()
        {
            Console.WriteLine("{0}...", PlaceName);
            Console.WriteLine();
            this.Script();
        }
        public abstract void Script();
    }
}
