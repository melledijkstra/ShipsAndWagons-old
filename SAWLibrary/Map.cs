using SAWLibrary.Transport.Ships;
using System.Collections.Generic;
using System.Windows;

namespace SAWLibrary
{
    public class Map
    {

        public int tiles { get; }

        // TODO: because the UI has to be updated when Ships change position, the Ships property has to do something with INotifyPropertyChanged
        public List<ShipBase> Ships
        {
            get { return new List<ShipBase>() { new Ship(new Point(1, 1)), new Ship(new Point(1, 1)) }; }
            set { }
        }

        public Map()
        {
            tiles = 20;
            Ships = new List<ShipBase>()
            {
                new Ship(new Point(200,20)),
                new Ship(new Point(340, 120)),
                new Ship(new Point(34, 120)),
                new Ship(new Point(340, 10)),
            };
        }

    }
}