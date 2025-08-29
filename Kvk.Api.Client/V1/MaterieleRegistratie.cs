using Kvk.Api.Client.Extensions;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class MaterieleRegistratie
{
    [JsonPropertyName("datumAanvang")]
    [JsonConverter(typeof(DateTimeYyyyMMddConverter))]
    //[JsonDateTimeConverterAttribute("yyyyMMdd")]
    public DateTime DatumAanvang { get; set; }

    [JsonPropertyName("datumEinde")]
    [JsonConverter(typeof(DateTimeYyyyMMddConverter))]
    //[JsonDateTimeConverterAttribute("yyyyMMdd")]
    public DateTime DatumEinde { get; set; }
}

