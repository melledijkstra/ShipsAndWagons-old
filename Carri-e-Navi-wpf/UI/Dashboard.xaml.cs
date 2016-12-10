using SAWLibrary;
using System.Windows;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard
    {
        public Dashboard()
        {
            InitializeComponent();
            System.Console.WriteLine("Dashboard view created");
            DataContext = Game.GetGame();
            if (DataContext != null)
            {
                MessageBox.Show(ToString() + " " + DataContext);
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // Navigate to the Map Page and pass the map object so the page fills it with the correct info
            NavigationService.Navigate(new MapPage(Game.Instance().Map));
        }

        private void UpdateName_OnClick(object sender, RoutedEventArgs e)
        {
            ((Game)DataContext).Player.Name = "Gladiator!";
        }
    }
}
