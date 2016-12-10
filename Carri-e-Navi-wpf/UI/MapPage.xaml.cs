using SAWLibrary;

namespace Carri_e_Navi_wpf
{
    /// <summary>
    /// Interaction logic for MapPage.xaml
    /// </summary>
    public partial class MapPage
    {

        private Map map;

        public MapPage(Map map)
        {
            this.map = map;
            DataContext = map;
            InitializeComponent();


        }
    }
}
