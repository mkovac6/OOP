using DataLayer;
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
using System.Windows.Shapes;

namespace WpfApp
{
    public partial class SettingsWindow : Window
    {
        private static string DEL = ";";
        private int closeCounter = 0;
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var checkedButton = mainGrid.Children.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.IsChecked == true);
           
            if (FormValid())
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(cbChamp.SelectedIndex + DEL);
                sb.Append(((ComboBoxItem)cbLang.SelectedItem).Tag.ToString() + DEL);
                sb.Append(((ComboBoxItem)cbSource.SelectedItem).Tag.ToString());


                
                Repository.WriteConfigFile(sb.ToString());
                Repository.WriteSelectedResolution(checkedButton.Tag.ToString());
                closeCounter++;
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Please fill all fields!");
            }
        }

        private bool FormValid()
        {
            return cbChamp.SelectedIndex != -1 && cbLang.SelectedIndex != -1 && cbSource.SelectedIndex != -1;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (closeCounter == 0)
            {
                MessageBox.Show("Closing this window without inputting settings will crash the app!");
                closeCounter++;
                e.Cancel = true;
            }
        }
    }
}
