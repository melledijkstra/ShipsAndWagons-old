using System;
using System.Windows;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Dashboard dashboard;

        public MainWindow()
        {
            InitializeComponent();

            MouseDown += delegate { DragMove(); };
        }

        private void NewGameBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Choose a name for the new save

            // Initialize new game

            // Show CoreWindow
            if (dashboard.IsLoaded)
            {

            }
            else
            {
                dashboard = new Dashboard();
            }
            Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
