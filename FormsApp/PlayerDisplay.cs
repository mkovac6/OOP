using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class PlayerDisplay : UserControl
    {
        public bool Selected = false;
        public bool Favourite = new bool();
        private StartingEleven player;
        public string imgPath { get; set; }
        public PlayerDisplay()
        {
            InitializeComponent();
            
        }
        public PlayerDisplay(StartingEleven player, bool favourite)
        {
            InitializeComponent();
            this.player = player;
            loadLabels(favourite);
            imgPath = @"../../../Images/blankPerson.png";
            setImage();
        }
        public PlayerDisplay(StartingEleven player, bool favourite, string path)
        {
            InitializeComponent();
            this.player = player;
            loadLabels(favourite);
            imgPath = path;
            setImage();
        }

        private void setImage() {

            pbIcon.ImageLocation = imgPath;
        }

        private void loadLabels(bool favourite)
        {
            lblName.Text = player.Name;
            lblNumber.Text = player.ShirtNumber.ToString();
            lblPosition.Text = player.Position;
            lblCaptaincy.Text = player.Captain ? "CAP" : "";
            lblIcon.Text = favourite ? "ˇ" : "";
            
        }

       

        public void setFavourite(bool fav) {
            Favourite = fav;

            lblIcon.Text = Favourite ? "ˇ" : "";
        }
       

        public string PlayerName => $"{player.Name}";

        private void PlayerDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            
               
            PlayerDisplay pd = (PlayerDisplay)sender;
            pd.DoDragDrop(pd,DragDropEffects.Move);
            


        }

        private void changePlayerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPlayerImage();
        }

        private void addPlayerImage()
        {
            string s = DataLayer.Repository.addNewImage(player.Name);
            pbIcon.ImageLocation = s;
        }
        public string getPlayerName()
        {
            return player.Name;
        }

        private void selectForTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected = true;
        }
    }
}
