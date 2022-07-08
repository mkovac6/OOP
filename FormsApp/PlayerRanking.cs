using FormsApp.Models;
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
{//prozorčić za igrače
    public partial class PlayerRanking : UserControl
    {
        public int Result { get; set; }
        public PlayerRanking()
        {
            InitializeComponent();
        }

        public PlayerRanking(PlayerData p)
        {
            InitializeComponent();
            pbIcon.ImageLocation = p.PicturePath;
            lblName.Text = p.PlayerName;
            lblResult.Text = $"{p.Result}";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
