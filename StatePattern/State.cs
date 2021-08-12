using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace StatePattern
{
    abstract public class State
    {
        protected Player _player;
        public void SetPlayer(Player player)
        {
            this._player = player;
        }

        public abstract void ClickPause(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow);
        public abstract void ClickPlay(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow);
        public abstract void ClickStop(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow);
        public abstract void Time(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow);
    }
}
