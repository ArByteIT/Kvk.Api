using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class HeeftAlsEigenaar
{
    [JsonPropertyName("rechtspersoon")]
    public Rechtspersoon Rechtspersoon { get; set; }
}
