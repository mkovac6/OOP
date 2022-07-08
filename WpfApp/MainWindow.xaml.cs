﻿using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class MainWindow : Window
    {
        bool IsMale = new bool();
        bool IsOnline = new bool();
        string Favourite;
        Dictionary<string, string> CountriesAndCodes = new Dictionary<string, string>();
        private List<Team> teams = new List<Team>();
        private List<Match> matches = new List<Match>();
        private Team MainTeam = new Team();
        private Team OtherTeam = new Team();
        private Match ActiveMatch = new Match();
        bool IsChanging;
        bool FirstRun = true;
        private List<StartingEleven> MainTeamPlayers;
        private List<StartingEleven> OtherTeamPlayers;
        Dictionary<string, string> imagePaths = Repository.ReadPicturePaths();
        Dictionary<string, PlayerMatchStatistics> PlayerStats = new Dictionary<string, PlayerMatchStatistics>();
        public MainWindow()
        {
            
            LoadSettings();
            InitializeComponent();
            SetWindowSize();
            GetTeamsAsync();
           
        }

        async private void GetTeamsAsync()
        {
            lsLoading.Visibility = Visibility.Visible;
            await Task.Run(() => {
                teams = Repository.getTeamData(IsOnline,IsMale);
                teams.ForEach(t => CountriesAndCodes.Add(t.FifaCode, $"{t.Country} ({t.FifaCode})" ));
            });

            cbMainTeam.ItemsSource = CountriesAndCodes;
            cbMainTeam.DisplayMemberPath = "Value";
            cbMainTeam.SelectedValuePath = "Key";
            if (CountriesAndCodes.ContainsKey(Favourite))
            {
                cbMainTeam.SelectedValue = Favourite;
            }
            lsLoading.Visibility = Visibility.Collapsed;

        }

       

        private void LoadSettings()
        {
           
            if (Repository.ConfigExists() && Repository.SelectedResolutionExists())
            {
                ImportConfig();
                try
                {
                    Favourite = Repository.readFavTeam();
                    
                    
                }
                catch (Exception)
                {

                    Favourite = "";
                }
            }
            else
            {
                var set = new SettingsWindow();
                set.ShowDialog();
                LoadSettings();
            }
        }

        private void ImportConfig()
        {
            List<string> settings = Repository.ReadConfigFile();

            IsMale = settings[0] == "0";
            string lang = settings[1];
            IsOnline = settings[2] == "True";


            SetLocalisation(lang);
             
        }

        private void SetWindowSize()
        {
            string size = Repository.ReadSelectedResolution();
            var info = size.Split(';');
            if (info[0] == "0")
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {

                this.Width = double.Parse(info[0]);
                this.Height = double.Parse(info[1]);

            }
        }

        private void SetLocalisation(string lang)
        {
            CultureInfo ci = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void cbMainTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clearPlayerGrid();
            if (MainTeamPlayers != null)
            {
                MainTeamPlayers = new List<StartingEleven>();
            }
            IsChanging = true;
            btnOtherTeamDisplay.IsEnabled = false;
            ClearMatchResults(); 
            if (cbMainTeam.SelectedItem != null)
            {

                MainTeam = teams.Find(t => t.FifaCode == cbMainTeam.SelectedValue.ToString());
                GetMatchesAsync(MainTeam.FifaCode); 
            }
            //GetPlayersAsync(MainTeam.FifaCode,IsMale,IsOnline,true);
        }

        async private void GetPlayersAsync(string code, bool isMale, bool isOnline, bool IsMainTeam)
        {
            List<StartingEleven> team = new List<StartingEleven>();
            await Task.Run(() => {
                team = Repository.getAllPlayers(isMale, isOnline, code);
            });
            if (IsMainTeam)
            {
                MainTeamPlayers = team;
            }
            else
            {
                OtherTeamPlayers = team;
            }
            DisplayPlayers(IsMainTeam);
        }

        private void DisplayPlayers(bool isMainTeam)
        {
            StackPanel pnlG;
            StackPanel pnlD;
            StackPanel pnlM;
            StackPanel pnlA;
            List<StartingEleven> players = isMainTeam ? MainTeamPlayers : OtherTeamPlayers;
            if (isMainTeam)
            {
                pnlG = pnlMainGoalee;
                pnlD = pnlMainDefence;
                pnlM = pnlMainMidfield;
                pnlA = pnlMainOffence;
            }

            else
            {
                pnlG = pnlOtherGoalee;
                pnlD = pnlOtherDefence;
                pnlM = pnlOtherMidfield;
                pnlA = pnlOtherOffence;
            }

            players.ForEach(p => {

                var ImagePath = imagePaths.FirstOrDefault(info => p.Name == info.Key);
                var MatchStats = PlayerStats.FirstOrDefault(stats => p.Name == stats.Key);
                var pdc = new PlayerDisplayControl(p,ImagePath.Value, MatchStats.Value);
                switch (p.Position) {

                    case "Goalie":
                        pnlG.Children.Add(pdc);
                        break;

                    case "Defender":
                        pnlD.Children.Add(pdc);
                        break;
                    case "Midfield":
                        pnlM.Children.Add(pdc);
                        break;
                    case "Forward":
                        pnlA.Children.Add(pdc);
                        break;
                
                }

            });

        }

        async private void GetMatchesAsync(string code)
        {
            lsLoading.Visibility = Visibility.Visible;
            await Task.Run(() => {
                matches = Repository.getMatchData(IsOnline, IsMale,code);
            });

            Dictionary<string, string> dct = new Dictionary<string, string>();
            var d = CountriesAndCodes.ToList(); 
            d.ForEach(c => {

                foreach (var match in matches)
                {
                if (  c.Key != MainTeam.FifaCode && (  c.Key == match.HomeTeam.Code || c.Key == match.AwayTeam.Code )  )
                {
                        dct.Add(c.Key,c.Value);
                }

                }
            
            });

            cbOtherTeam.ItemsSource = dct;
            cbOtherTeam.DisplayMemberPath = "Value";
            cbOtherTeam.SelectedValuePath = "Key";
            lsLoading.Visibility = Visibility.Collapsed;
        }

        private void cbOtherTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             clearPlayerGrid();
            
            if (!IsChanging || FirstRun)
            {

                if (OtherTeamPlayers != null)
                {
                    OtherTeamPlayers = new List<StartingEleven>();
                }

                if (cbOtherTeam.SelectedItem != null)
                {
                    OtherTeam = teams.Find(t => t.FifaCode == cbOtherTeam.SelectedValue.ToString());
                    //GetPlayersAsync(OtherTeam.FifaCode, IsMale, IsOnline, false);
                    btnOtherTeamDisplay.IsEnabled = true;
                    SetMatchResults();

                    FirstRun = false; 
                }
            }
            IsChanging = false;
            
        }

        private void clearPlayerGrid()
        {
            grdMainTeamStartingEleven.Children.Cast<StackPanel>().ToList().ForEach(sp => sp.Children.Clear());
            grdOtherTeamStartingEleven.Children.Cast<StackPanel>().ToList().ForEach(sp => sp.Children.Clear());
        }

        private void SetMatchResults()
        {
            PlayerStats = new Dictionary<string, PlayerMatchStatistics>();
            ActiveMatch = matches.Find(m => (m.HomeTeam.Code == MainTeam.FifaCode && m.AwayTeam.Code == OtherTeam.FifaCode) ||
                                          (m.HomeTeam.Code == OtherTeam.FifaCode && m.AwayTeam.Code == MainTeam.FifaCode));
            lblScoreDelimiter.Visibility = Visibility.Visible;
            if (ActiveMatch.HomeTeam.Code == MainTeam.FifaCode)
            {
                lblMainTeamScore.Content = ActiveMatch.HomeTeam.Goals;
                lblOtherTeamScore.Content = ActiveMatch.AwayTeam.Goals;
                MainTeamPlayers = ActiveMatch.HomeTeamStatistics.StartingEleven;
                OtherTeamPlayers = ActiveMatch.AwayTeamStatistics.StartingEleven;
               
                
            }
            else
            {
                lblOtherTeamScore.Content = ActiveMatch.HomeTeam.Goals;
                lblMainTeamScore.Content = ActiveMatch.AwayTeam.Goals;
                OtherTeamPlayers = ActiveMatch.HomeTeamStatistics.StartingEleven;
                MainTeamPlayers = ActiveMatch.AwayTeamStatistics.StartingEleven;
            }
            FillMatchStatistics();
            DisplayPlayers(true);
            DisplayPlayers(false);
        }

        private void FillMatchStatistics()
        {
            MainTeamPlayers.ForEach(player => {

                PlayerStats.Add(player.Name, new PlayerMatchStatistics 
                { GoalsScored = ActiveMatch.getGoalsScored(player.Name),
                    YellowCards = ActiveMatch.getYellowCards(player.Name) });

            });
            OtherTeamPlayers.ForEach(player => {

                PlayerStats.Add(player.Name, new PlayerMatchStatistics 
                { GoalsScored = ActiveMatch.getGoalsScored(player.Name),
                    YellowCards = ActiveMatch.getYellowCards(player.Name) });

            });
        }

        private void ClearMatchResults()
        {
           
                lblOtherTeamScore.Content = "";
                lblMainTeamScore.Content = "";
                lblScoreDelimiter.Visibility = Visibility.Hidden;
            
        }

        private void btnMainTeamDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (cbMainTeam.SelectedIndex != -1)
            {
                showTeamStats(MainTeam); 
            }
        }

       

        private void btnOtherTeamDisplay_Click(object sender, RoutedEventArgs e)
        {
            showTeamStats(OtherTeam);
        }

        private void showTeamStats(Team team)
        {
            var s = new TeamShowcaseWindow(team);
            s.Show();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            var setWindow = new SettingsShortcutWindow();
            if (setWindow.ShowDialog() == true)
            {
                clearPlayerGrid();
                clearData();
                LoadSettings();
                InitializeComponent();
                SetWindowSize();
                GetTeamsAsync();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var cw = new ClosingWindow();
            if (cw.ShowDialog() == false)
            {
                e.Cancel = true;
            }
        }

        private void clearData()
        {
        CountriesAndCodes = new Dictionary<string, string>();
        teams = new List<Team>();
        matches = new List<Match>();
        MainTeam = new Team();
        OtherTeam = new Team();
        ActiveMatch = new Match();
        FirstRun = true;
        MainTeamPlayers = new List<StartingEleven>();
        OtherTeamPlayers = new List<StartingEleven>();
        cbOtherTeam.SelectedIndex = -1;
            cbMainTeam.SelectedIndex = -1;
        
        
       
        }

    }
}
