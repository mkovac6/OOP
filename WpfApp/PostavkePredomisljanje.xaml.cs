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
    public partial class SettingsShortcutWindow : Window
    {
        private static string DEL = ";";
        public SettingsShortcutWindow()
        {
            InitializeComponent();
            AddHotKeys();
        }
        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(firstSettings, btnCancel_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.Enter));
                CommandBindings.Add(new CommandBinding(secondSettings, btnSubmit_Click));
            }
            catch (Exception)
            {
                
            }
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
                
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Please fill all fields!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private bool FormValid()
        {
            return cbChamp.SelectedIndex != -1 && cbLang.SelectedIndex != -1 && cbSource.SelectedIndex != -1;
        }
    }
}
