using System.Windows;

namespace SAWLibrary.Transport.Ships
{
    public abstract class ShipBase : TransportBase
    {
        public Point location;

        protected ShipBase(Point location)
        {
            this.location = location;
        }

        public abstract void Update();

    }
}