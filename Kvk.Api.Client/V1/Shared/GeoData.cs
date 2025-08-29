using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Shared;

public class GeoData
{
    [JsonPropertyName("addresseerbaarObjectId")]
    public string? AddresseerbaarObjectId { get; set; }

    [JsonPropertyName("nummerAanduidingId")]
    public string? NummerAanduidingId { get; set; }

    [JsonPropertyName("gpsLatitude")]
    public int? GpsLatitude { get; set; }

    [JsonPropertyName("gpsLongitude")]
    public int? GpsLongitude { get; set; }

    [JsonPropertyName("rijksdriehoekX")]
    public int? RijksdriehoekX { get; set; }

    [JsonPropertyName("rijksdriehoekY")]
    public int? RijksdriehoekY { get; set; }

    [JsonPropertyName("rijksdriehoekZ")]
    public int? RijksdriehoekZ { get; set; }
}

