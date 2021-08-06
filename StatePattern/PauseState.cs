using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class PauseState : State
    {
        public override void ClickPause()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.lbl.Content = "Pause";
            mainWindow.ShowDialog();
        }

        public override void ClickPlay()
        {
            this._player.changeState(new PlayState());
            MainWindow mainWindow = new MainWindow();
            mainWindow.lbl.Content = "Play";
            mainWindow.ShowDialog();
        }

        public override void ClickStop()
        {
            this._player.changeState(new StopState());
            MainWindow mainWindow = new MainWindow();
            mainWindow.lbl.Content = "Stop";
            mainWindow.ShowDialog();
        }
    }
}
