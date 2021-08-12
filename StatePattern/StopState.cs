﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace StatePattern
{
    public class StopState : State
    {
        public MediaPlayer MediaPlayer { get; set; }
        public StopState(MediaPlayer mediaPlayer)
        {
            MediaPlayer = mediaPlayer;
        }
        public override void ClickPause(MediaPlayer mediaPlayer,Music music,MainWindow mainWindow)
        {
            MessageBox.Show("");
        }

        public override void ClickPlay(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            MessageBox.Show("");
        }

        public override void ClickStop(MediaPlayer mediaPlayer, Music music, MainWindow mainWindow)
        {
            mediaPlayer.Stop();   
        }
        public override void Time(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {
            MessageBox.Show("");
        }
    }
}
