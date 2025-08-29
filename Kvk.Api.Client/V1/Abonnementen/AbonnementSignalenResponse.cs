using Kvk.Api.Client.V1.Basisprofielen;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class AbonnementSignalenResponse
{
    [JsonPropertyName("signaal")]
    public Signaal Signaal { get; set; }
}
