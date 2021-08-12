using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace StatePattern
{
    public class TimeState:State
    {
        public MediaPlayer MediaPlayer { get; set; }
        public TimeState(MediaPlayer mediaPlayer)
        {
            MediaPlayer = mediaPlayer;
        }
        public override void ClickPause(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            MessageBox.Show("");
        }

        public override void ClickPlay(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            MessageBox.Show("");
        }

        public override void ClickStop(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            MessageBox.Show("");
        }
        public override void Time(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {
            mainWindow.startLbl.Content = string.Format(mediaPlayer.Position.ToString(@"mm\:ss")); ; ;
            mainWindow.endLbl.Content = string.Format(mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            mainWindow.slider.Visibility = Visibility.Visible;
            timeSpan = mediaPlayer.NaturalDuration.TimeSpan;
            mainWindow.slider.Minimum = 0;
            mainWindow.slider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            mainWindow.slider.SmallChange = 1;
            mainWindow.slider.LargeChange = Math.Min(10, timeSpan.Seconds / 10);
            mainWindow.slider.Value = mediaPlayer.Position.TotalSeconds;
        }
    }
}

