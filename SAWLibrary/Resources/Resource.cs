using System;

namespace SAWLibrary.Resources
{

    public class Resource
    {

        public enum ResourceType
        {
            Wood = 1,
            Iron = 2,
            Gold = 3
        }

        public string name => type.ToString();
        public int GetResourceID => (int)type;

        private readonly ResourceType type;
        private float _value;
        private float _weight;

        public Resource(ResourceType type, float value, float weight)
        {
            this.type = type;
            _value = value;
            _weight = weight;
        }

    }

    public static class ResourceTypeWeigths
    {
        public static float Weight(this Resource.ResourceType self)
        {
            switch (self)
            {
                case Resource.ResourceType.Wood:
                    break;
                case Resource.ResourceType.Iron:
                    break;
                case Resource.ResourceType.Gold:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(self), self, null);
            }
            return 1.0f;
        }
    }
}