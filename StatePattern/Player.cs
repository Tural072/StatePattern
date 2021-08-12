using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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

        public void ClickPlay(MediaPlayer mediaPlayer,Music music,MainWindow mainWindow) 
        {
            this._state.ClickPlay(mediaPlayer,music,mainWindow);
        }
        public void ClickPause(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            this._state.ClickPause(mediaPlayer, music, mainWindow);
        }
        public void ClickStop(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            this._state.ClickStop(mediaPlayer, music, mainWindow);
        }

        public void Time(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {
            this._state.Time(mediaPlayer, timeSpan, mainWindow);
        }
    }
}
