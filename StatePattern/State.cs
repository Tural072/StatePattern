using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    abstract public class State
    {
        protected Player _player;
        public void SetPlayer(Player player)
        {
            this._player = player;
        }

        public abstract void ClickPause();
        public abstract void ClickPlay();
        public abstract void ClickStop();
    }
}
