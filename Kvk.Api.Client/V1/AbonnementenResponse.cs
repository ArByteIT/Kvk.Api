using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class AbonnementenResponse
{
    [JsonPropertyName("klantId")]
    public string? KlantId { get; set; }

    [JsonPropertyName("abonnementen")]
    public List<Abonnement> Abonnementen { get; set; }
}
