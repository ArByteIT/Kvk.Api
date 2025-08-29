using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Embedded
{
    [JsonPropertyName("hoofdvestiging")]
    public Hoofdvestiging Hoofdvestiging { get; set; }

    [JsonPropertyName("eigenaar")]
    public EmbeddedEigenaar Eigenaar { get; set; }
}

