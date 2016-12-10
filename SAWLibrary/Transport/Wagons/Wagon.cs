using SAWLibrary.Resources;
using System.Collections.Generic;

namespace SAWLibrary.Transport.Wagons
{
    public class Wagon : WagonBase
    {

        private Inventory Inventory;
        List<Resource> buildingRequirements { get; }

        protected Wagon()
        {

        }

        public static Wagon BuildWagon(Inventory inventory)
        {
            // Check if enough resources for this Wagon


            // If so then 
            return new Wagon();
        }

    }
}