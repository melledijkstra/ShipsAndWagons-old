using System;
using System.Windows;

namespace SAWLibrary.Transport.Ships
{
    public class Ship : ShipBase
    {
        public Ship(Point location) : base(location)
        {
            Console.WriteLine("Ship made at location - [" + location.X + "," + location.Y + "]");
        }

        public override void Update()
        {
            location.X += 3;
        }
    }
}