namespace SAWLibrary
{
    public class Warehouse
    {

        public Inventory inventory { get; }

        public Warehouse()
        {
            inventory = new Inventory();
        }
    }
}