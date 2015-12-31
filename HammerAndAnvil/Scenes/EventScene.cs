using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Scenes
{
    abstract class EventScene : IScene
    {
        public void Run()
        {
            this.Script();
        }
        public abstract void Script();
    }
}
