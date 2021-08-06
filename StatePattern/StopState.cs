using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StopState : State
    {
        public override void ClickPause()
        {
            this._player.changeState(new PauseState());
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.lbl.Content = "Stop";
            mainWindow.ShowDialog();
        }
    }
}
