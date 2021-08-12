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
using System.Windows.Threading;

namespace StatePattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private bool _isDragging = false;

        public Music Music { get; set; }

        public MainWindow()
        {
            string Filepath = "../../Music/2pac-only-god-can-judge-me.mp3";
            Music = new Music
            {
                MusicPath = Filepath
            };

            mediaPlayer.Open(new Uri(Music.MusicPath, UriKind.RelativeOrAbsolute));


            this.DataContext = this;


            InitializeComponent();
        }

        public object selecti;


        string location = "";


        private MediaPlayer mediaPlayer = new MediaPlayer();

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new PlayState(mediaPlayer));
            play.ClickPlay(mediaPlayer, Music, this);
            Timer();
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new StopState(mediaPlayer));

            play.ClickStop(mediaPlayer, Music, this);

            Timer();
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new PauseState(mediaPlayer));

            play.ClickPause(mediaPlayer, Music, this);

            Timer();
        }

        public void Timer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mediaPlayer.Source != null)
                {
                    TimeSpan ts = new TimeSpan();

                    Player play = new Player(new TimeState(mediaPlayer));
                    play.Time(mediaPlayer, ts, this);

                }

            }
            catch (Exception)
            {

            }

        }

        private void TimeSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            _isDragging = true;
        }

        private void TimeSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            _isDragging = false;
            mediaPlayer.Position = TimeSpan.FromSeconds(slider.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
