using Newtonsoft.Json.Linq;
using SAWLibrary.Annotations;
using SAWLibrary.Transport.Ships;
using SAWLibrary.Transport.Wagons;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SAWLibrary.Entities
{
    public class Player : INotifyPropertyChanged
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public List<ShipBase> Ships;
        public List<WagonBase> Wagons;
        public Warehouse Warehouse;
        public int florins;

        public Player(string name, int startingMoney = 200)
        {
            Name = name;
            florins = startingMoney;
            Ships = new List<ShipBase>();
            Wagons = new List<WagonBase>();
            Warehouse = new Warehouse();
        }

        public JObject Save()
        {
            return new JObject();
        }

        // All this stuff makes it possible to automaticly update the playername in the UI
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}