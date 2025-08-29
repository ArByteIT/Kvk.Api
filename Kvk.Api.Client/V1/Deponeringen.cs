using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Deponeringen
{
    [JsonPropertyName("gewijzigdeDeponeringen")]
    public List<object> GewijzigdeDeponeringen { get; set; }
}
