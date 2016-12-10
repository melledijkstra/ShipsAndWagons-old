namespace SAWLibrary.Resources
{
    public class ResourcePile
    {
        Resource Resource;
        int quantity;

        public ResourcePile(Resource resource, int quantity = 1)
        {
            Resource = resource;
            this.quantity = quantity;
        }

    }
}