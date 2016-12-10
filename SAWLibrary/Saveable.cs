using Newtonsoft.Json.Linq;

namespace SAWLibrary
{
    public interface Saveable
    {
        JObject Save(JObject jobj);
    }
}