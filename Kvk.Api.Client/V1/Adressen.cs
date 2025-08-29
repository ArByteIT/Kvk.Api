using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Adressen
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("indAfgeschermd")]
    public string? IndAfgeschermd { get; set; }

    [JsonPropertyName("volledigAdres")]
    public string? VolledigAdres { get; set; }

    [JsonPropertyName("straatnaam")]
    public string? Straatnaam { get; set; }

    [JsonPropertyName("huisnummer")]
    public int? Huisnummer { get; set; }

    [JsonPropertyName("huisletter")]
    public string? Huisletter { get; set; }

    [JsonPropertyName("huisnummerToevoeging")]
    public string? HuisnummerToevoeging { get; set; }

    [JsonPropertyName("toevoegingAdres")]
    public string? ToevoegingAdres { get; set; }

    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    [JsonPropertyName("postbusnummer")]
    public int? Postbusnummer { get; set; }

    [JsonPropertyName("plaats")]
    public string? Plaats { get; set; }

    [JsonPropertyName("straatHuisnummer")]
    public string? StraatHuisnummer { get; set; }

    [JsonPropertyName("postcodeWoonplaats")]
    public string? PostcodeWoonplaats { get; set; }

    [JsonPropertyName("regio")]
    public string? Regio { get; set; }

    [JsonPropertyName("land")]
    public string? Land { get; set; }

    [JsonPropertyName("geoData")]
    public GeoData GeoData { get; set; }
}

