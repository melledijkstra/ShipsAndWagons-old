using SAWLibrary;
using System.Windows;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            DataContext = Game.GetGame();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            // Check if any settings aren't saves, ask user to save edits
            Close();
        }

        private void TextBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DataContext: " + DataContext);
        }
    }
}
