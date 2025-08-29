using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Contract
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
