using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class GewijzigdeVestigingenVestigingen
{
    [JsonPropertyName("gewijzigdevestigingen")]
    public List<object> Gewijzigdevestigingen { get; set; }
}
