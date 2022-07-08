using DataLayer.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataLayer
{
    public class Repository
    {//Povezivanje sa linkovima/čitanje iz .txt
        private const string MaleTeamUrl = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private const string FemaleTeamUrl = "http://worldcup.sfg.io/teams/results";
        private const string MaleTeamFilePath = @"../../../Config/worldcup.sfg.io\men\results.json";
        private const string FemaleTeamFilePath = @"../../../Config/worldcup.sfg.io\women\results.json";

        private const string MaleMatchUrl = "https://world-cup-json-2018.herokuapp.com/matches";
        private const string FemaleMatchUrl = "http://worldcup.sfg.io/matches/";
        private const string MaleMatchFilePath = @"../../../Config/worldcup.sfg.io\men\matches.json";
        private const string FemaleMatchFilePath = @"../../../Config/worldcup.sfg.io\women\matches.json";

        private const string MaleMatchPerCountryUrl = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string FemaleMatchPerCountryUrl = "http://worldcup.sfg.io/matches/country?fifa_code=";

        private const char DEL = ';';
        private const string ConfigPath = @"../../../Config/config.txt";
        private const string FavTeamPath = @"../../../Config/favteam.txt";
        private const string ResolutionPath = @"../../../Config/screenres.txt";
        private const string FavPlayersPath = @"../../../Config/favplayers.txt";
        private const string PlayerPicturePath = @"../../../Config/picturepaths.txt";

        //Igrači metode:

        public static void writeFavPlayers(List<string> players)
        {
            File.WriteAllLines(FavPlayersPath, players);
        }
        public static List<string> readFavPlayers()
        {


            try
            {
                return File.ReadAllLines(FavPlayersPath).ToList();
            }
            catch (Exception)
            {

                return new List<string>();
            }



        }

        public static List<StartingEleven> getAllPlayers(bool IsMale, bool IsOnline, string code)
        {
            List<StartingEleven> players = new List<StartingEleven>();

            var match = getMatchData(IsOnline, IsMale, code).First();

            if (match.HomeTeam.Code == code)
            {
                players = match.HomeTeamStatistics.StartingEleven;
                players.AddRange(match.HomeTeamStatistics.Substitutes);
            }
            else
            {
                players = match.AwayTeamStatistics.StartingEleven;
                players.AddRange(match.AwayTeamStatistics.Substitutes);
            }

            return players;
        }

        public static string addNewImage(string name)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.InitialDirectory = "images";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog.FileName;

                saveImagePath(name, s);

                return s;
            }
            else
            {
                return null;
            }
        }

        private static bool ImagePathExists() {

            try
            {
                var lines = File.ReadAllLines(PlayerPicturePath);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
        }
        private static void saveImagePath(string name, string path)
        {
            if (ImagePathExists())
            {
                var lines = File.ReadAllLines(PlayerPicturePath).ToList();
                lines.RemoveAll(l => l.Split(DEL)[0] == name);

                lines.Add(name + DEL + path);

                File.WriteAllLines(PlayerPicturePath, lines); 
            }
            else
            {
                File.WriteAllText(PlayerPicturePath, name + DEL + path);
            }

        }

        //Zemlje metode:


        public static Dictionary<string, string> getCountriesAndCodes(bool IsMale, bool IsOnline)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            List<Team> tempTeams = IsMale ? getTeamData(IsOnline, true) : getTeamData(IsOnline, false);

            foreach (var team in tempTeams)
            {
                d.Add(team.FifaCode, $"{team.Country} ({team.FifaCode})");
            }

            return d;
        }

        //Utakmice metode:

        public static List<Match> getMatchesByCountryCode(string url, string countryCode)
        {
            var apiClient = new RestClient(url + countryCode);

            var apiResult = apiClient.Execute<List<Match>>(new RestRequest());

            return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);
        }



        public static List<Match> getMatchData(bool isOnline, bool isMale)
        {
            List<Match> matches;

            if (isOnline)
            {
                matches = isMale ? getMatchesFromApi(MaleMatchUrl) : getMatchesFromApi(FemaleMatchUrl);
            }
            else
            {
                matches = isMale ? getMatchesFromFile(MaleMatchFilePath) : getMatchesFromFile(FemaleMatchFilePath);
            }

            return matches;
        }

        public static List<Match> getMatchData(bool isOnline, bool isMale, string code)
        {
            List<Match> matches;

            if (isOnline)
            {
                matches = isMale ? getMatchesByCountryCode(MaleMatchPerCountryUrl, code) : getMatchesByCountryCode(FemaleMatchPerCountryUrl, code);
            }
            else
            {
                matches = isMale ? getMatchesFromFile(MaleMatchFilePath) : getMatchesFromFile(FemaleMatchFilePath);

                List<Match> filteredMatches = matches.FindAll(m => m.HomeTeam.Code == code || m.AwayTeam.Code == code);

                return filteredMatches;
            }

            return matches;
        }

        public static List<Match> getMatchesFromApi(string url)
        {
            var apiClient = new RestClient(url);

            var apiResult = apiClient.Execute<List<Match>>(new RestRequest());

            return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);
        }

        private static List<Match> getMatchesFromFile(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Match> items = JsonConvert.DeserializeObject<List<Match>>(json);
                return items;
            }
        }

        //Timovi metode:

        public static List<Team> getTeamData(bool isOnline, bool isMale)
        {
            List<Team> teams;

            if (isOnline)
            {
                teams = isMale ? getTeamsFromApi(MaleTeamUrl) : getTeamsFromApi(FemaleTeamUrl);
            }
            else
            {
                teams = isMale ? getTeamsFromFile(MaleTeamFilePath) : getTeamsFromFile(FemaleTeamFilePath);
            }

            return teams;
        }

        public static void writeFavTeam(string code)
        {
            File.WriteAllText(FavTeamPath, code);
        }

        public static string readFavTeam()
        {
            try
            {

                return File.ReadAllText(FavTeamPath);
            }
            catch (Exception)
            {

                throw new Exception("Error reading favourite team");
            }
        }



        private static List<Team> getTeamsFromApi(string url)
        {
            var apiClient = new RestClient(url);

            var apiResult = apiClient.Execute<List<Team>>(new RestRequest());

            return JsonConvert.DeserializeObject<List<Team>>(apiResult.Content);
        }

        private static List<Team> getTeamsFromFile(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Team> items = JsonConvert.DeserializeObject<List<Team>>(json);
                return items;
            }
        }


        //Metode za konfiguraciju:


        public static void WriteConfigFile(string configString) //Konfiguracija 1
        {
            File.WriteAllText(ConfigPath, configString);
        }

        public static bool ConfigExists() //Konfiguracija 2
        {
            try
            {
                var s = File.ReadAllLines(ConfigPath);

                return s[0] != "";
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<string> ReadConfigFile() //Konfiguracija 3
        {
            List<string> data = new List<string>();

            var line = File.ReadAllText(ConfigPath);

            var s = line.Split(DEL);

            for (int i = 0; i < s.Length; i++)
            {
                data.Add(s[i]);
            }
            return data;
        }

        public static bool SelectedResolutionExists() {

            try
            {
                File.ReadAllText(ResolutionPath);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
        }

        public static void WriteSelectedResolution(string v) //Konfiguracija 4
        {
            File.WriteAllText(ResolutionPath, v);
        }

        public static string ReadSelectedResolution()
        {
            return File.ReadAllText(ResolutionPath);
        }
        public static Dictionary<string, string> ReadPicturePaths() //Konfiguracija 5
        {
            try
            {

                Dictionary<string, string> dict = new Dictionary<string, string>();

                var lines = File.ReadAllLines(PlayerPicturePath);

                foreach (var line in lines)
                {
                    var words = line.Split(DEL);
                    dict.Add(words[0], words[1]);
                }

                return dict;
            }
            catch (Exception)
            {

                return new Dictionary<string, string>();
            }
        }
    }
}