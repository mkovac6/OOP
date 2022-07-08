using DataLayer.Models;
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
using WpfApp.Models;

namespace WpfApp
{
    public partial class PlayerDisplayControl : UserControl
    {
        StartingEleven Player;
        PlayerMatchStatistics PlayerStats;

        public PlayerDisplayControl(StartingEleven player, string path, PlayerMatchStatistics stats)
        {
            InitializeComponent();
            this.Width = 75;
            this.Height = 75;
            Player = player;
            PlayerStats = stats;
            init(path);
        }

        private void init(string path)
        {
            string fullname = Player.Name.ToUpper();
            var splitname = fullname.Split(' ');
            lblPlayerName.Content = splitname[0]; 
            if (splitname.Count() > 1)
            {

                lblPlayerLastname.Content = splitname[1]; 
            }
            lblShirtNumber.Content = Player.ShirtNumber;
            if (path != null)
            {
                imgPlayerImage.Source = new BitmapImage(new Uri(path));
            }
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var psw = new PlayerShowcaseWindow(Player, PlayerStats, imgPlayerImage.Source);
            psw.Show();
        }
    }
}
