using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Eigenaar
{
    [JsonPropertyName("beperkingInRechtshandeling")]
    public bool? BeperkingInRechtshandeling { get; set; }

    [JsonPropertyName("bijzondererechtstoestand")]
    public bool? Bijzondererechtstoestand { get; set; }

    [JsonPropertyName("buitenlandseVennootschap")]
    public bool? BuitenlandseVennootschap { get; set; }

    [JsonPropertyName("eenmanszaak")]
    public bool? Eenmanszaak { get; set; }

    [JsonPropertyName("eenmanszaakMetMeerdereEigenaren")]
    public bool? EenmanszaakMetMeerdereEigenaren { get; set; }

    [JsonPropertyName("fusieEnSplitsing")]
    public bool? FusieEnSplitsing { get; set; }

    [JsonPropertyName("ontbindingEnLiquidatie")]
    public bool? OntbindingEnLiquidatie { get; set; }

    [JsonPropertyName("rechtspersoon")]
    public bool? Rechtspersoon { get; set; }

    [JsonPropertyName("rechtspersoonActiviteiten")]
    public bool? RechtspersoonActiviteiten { get; set; }

    [JsonPropertyName("rechtspersoonAdresgegevens")]
    public bool? RechtspersoonAdresgegevens { get; set; }

    [JsonPropertyName("rechtspersoonInOprichting")]
    public bool? RechtspersoonInOprichting { get; set; }

    [JsonPropertyName("samenwerkingsverband")]
    public bool? Samenwerkingsverband { get; set; }
}