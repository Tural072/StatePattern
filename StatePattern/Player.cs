using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Player
    {
        private State _state = null;
        public Player(State state)
        {
            this.changeState(state);
        }
        public void changeState(State state) 
        {
            this._state = state;
            this._state.SetPlayer(this);
        }

        public void ClickPlay() 
        {
            this._state.ClickPlay();
        }
        public void ClickPause()
        {
            this._state.ClickPause();
        }
        public void ClickStop()
        {
            this._state.ClickStop();
        }
    }
}
