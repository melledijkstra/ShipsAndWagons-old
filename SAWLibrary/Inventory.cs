using SAWLibrary.Resources;
using System.Collections.Generic;
using static SAWLibrary.Resources.Resource;
using static System.Console;

namespace SAWLibrary
{
    public class Inventory
    {
        HashSet<ResourcePile> resources;

        public Inventory(HashSet<ResourcePile> rp)
        {
            resources = rp;
            WriteLine("Inventory filled");
        }

        public Inventory()
        {
            resources = new HashSet<ResourcePile>();
        }

        public void AddResource(ResourcePile resource)
        {
            resources.Add(resource);
        }

        public void AddResource(ResourceType type, double value, int amount = 1)
        {
            Resource resource = new Resource(type, type.Weight(), 1f);
            ResourcePile resourcePile = new ResourcePile(resource, amount);
            resources.Add(resourcePile);
        }

    }
}