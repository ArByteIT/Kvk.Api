using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Deponeringen
{
    [JsonPropertyName("gewijzigdeDeponeringen")]
    public List<object> GewijzigdeDeponeringen { get; set; } = new List<object>();
}
