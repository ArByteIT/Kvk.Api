using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class HeeftAlsEigenaar
{
    [JsonPropertyName("rechtspersoon")]
    public Rechtspersoon? Rechtspersoon { get; set; }
}
