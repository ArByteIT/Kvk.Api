using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class AdditionalPropLinks
{
    [JsonPropertyName("additionalProp1")]
    public AdditionalProp1 AdditionalProp1 { get; set; }

    [JsonPropertyName("additionalProp2")]
    public AdditionalProp2 AdditionalProp2 { get; set; }

    [JsonPropertyName("additionalProp3")]
    public AdditionalProp3 AdditionalProp3 { get; set; }
}

