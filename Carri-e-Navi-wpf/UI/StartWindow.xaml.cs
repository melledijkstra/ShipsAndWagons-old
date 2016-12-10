using Microsoft.Win32;
using SAWLibrary;
using System;
using System.Windows;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private PrimaryWindow primaryWindow;

        public MainWindow()
        {
            InitializeComponent();

            if (DataContext != null)
            {
                MessageBox.Show(DataContext.ToString());
            }

            MouseDown += delegate { DragMove(); };
        }

        private void NewGameBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (Game.Started)
            {
                MessageBox.Show("Already a game loaded!", "Save already loaded", MessageBoxButton.OK);
            }
            else
            {
                // Choose a name for the new save
                MessageBox.Show("Popup with name to choose for game", "Save Name", MessageBoxButton.OK, MessageBoxImage.Question);
                // Initialize new game
                Game.Init();
            }

            // Show PrimaryWindow
            if (primaryWindow == null)
            {
                primaryWindow = new PrimaryWindow();
            }
            primaryWindow.Show();
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

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "SAW Saves (*.saw)|*.saw|All files (*.*)|*.*" };
            if (openFileDialog.ShowDialog() == true)
            {
                Game.LoadFromFile(openFileDialog.FileName);
            }
        }

        private void SettingsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}
