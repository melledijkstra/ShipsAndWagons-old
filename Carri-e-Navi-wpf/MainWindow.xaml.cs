namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += delegate { DragMove(); };
        }
    }
}
