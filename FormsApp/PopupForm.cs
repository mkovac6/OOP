using DataLayer;
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
{//ovdje prozor za prvi prozor(jezik, prventsvo(dropdown), internet)

    public partial class PopupForm : Form
    {
        private static string DEL = ";";
        public PopupForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

                var selectedLang = gbLangauge.Controls.OfType<RadioButton>()
                                             .FirstOrDefault(r => r.Checked);


            if (FormValid(selectedLang))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(cbChamp.SelectedIndex + DEL);
                sb.Append(selectedLang.Tag.ToString() + DEL);
                sb.Append(chbIsOnline.Checked.ToString());

               

                Repository.WriteConfigFile(sb.ToString());
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill all fields!");
            }
        }

        private bool FormValid(RadioButton sl)
        {
            return cbChamp.SelectedIndex != -1 && sl != null;
           
        }

        private void rbCro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
