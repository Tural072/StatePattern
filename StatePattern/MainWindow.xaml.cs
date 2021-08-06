using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StatePattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            var player = new Player(new PauseState());
            player.ClickPause();
            player.ClickPlay();
            player.ClickStop();
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            var player = new Player(new PlayState());
            player.ClickPause();
            player.ClickPlay();
            player.ClickStop();
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            var player = new Player(new StopState());
            player.ClickPause();
            player.ClickPlay();
            player.ClickStop();
        }
    }
}
