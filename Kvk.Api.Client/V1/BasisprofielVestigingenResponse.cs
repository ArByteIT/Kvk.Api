using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class BasisprofielVestigingenResponse
{
    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("aantalCommercieleVestigingen")]
    public int? AantalCommercieleVestigingen { get; set; }

    [JsonPropertyName("aantalNietCommercieleVestigingen")]
    public int? AantalNietCommercieleVestigingen { get; set; }

    [JsonPropertyName("totaalAantalVestigingen")]
    public int? TotaalAantalVestigingen { get; set; }

    [JsonPropertyName("vestigingen")]
    public List<BasisprofielVestigingen> Vestigingen { get; set; }

    [JsonPropertyName("_links")]
    public Links Links { get; set; }
}
