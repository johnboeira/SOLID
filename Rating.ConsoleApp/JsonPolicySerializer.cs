using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rating.ConsoleApp;

public class JsonPolicySerializer
{
    public Policy GetPolicyFromJsonString(string jsonString)
    {
        return JsonConvert.DeserializeObject<Policy>(jsonString,
            new StringEnumConverter());
    }
}