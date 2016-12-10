using SAWLibrary;
using System;
using System.Windows;
using System.Windows.Input;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class PrimaryWindow : Window
    {

        public PrimaryWindow()
        {
            InitializeComponent();

            DataContext = Game.GetGame();

            ContentFrame.Content = new Dashboard();

            Console.WriteLine("Primary Window instanciated");
            if (DataContext != null)
            {
                MessageBox.Show(ToString() + " " + DataContext.ToString());
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            if (Application.Current.MainWindow != null && Application.Current.MainWindow.IsLoaded)
            {
                Application.Current.MainWindow.Show();
            }
            else
            {
                Application.Current.Shutdown();
            }
            base.OnClosed(e);
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
        }

        private void DragControl_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            e.Handled = true;
        }

        private void SaveBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Save the game
            /*if (Game.Started)
            {
                // TODO: Save game should not be called after static Instance method, because it's possible that Instance creates a new game
                //Game.Instance().SaveGame();
            }*/
        }
    }
}
