using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class AbonnementSignalenResponse
{
    [JsonPropertyName("signaal")]
    public Signaal Signaal { get; set; }
}
