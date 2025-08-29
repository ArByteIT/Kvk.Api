using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Contract
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
