using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard_Window : Window
    {
        public Dashboard_Window()
        {
            InitializeComponent();
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

        private void DragControl_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Image map = new Image();
            map.Width = Width;
            map.Source = new BitmapImage(new Uri(@"/Carri_e_Navi;images/backgrounds/map.jpg", UriKind.Relative));
            Content = map;
        }
    }
}
