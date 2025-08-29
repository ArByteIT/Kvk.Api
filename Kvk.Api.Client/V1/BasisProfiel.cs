using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class BasisProfiel
{
    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("indNonMailing")]
    public string? IndNonMailing { get; set; }

    [JsonPropertyName("naam")]
    public string? Naam { get; set; }

    [JsonPropertyName("formeleRegistratiedatum")]
    public string? FormeleRegistratiedatum { get; set; }

    [JsonPropertyName("materieleRegistratie")]
    public MaterieleRegistratie MaterieleRegistratie { get; set; }

    [JsonPropertyName("totaalWerkzamePersonen")]
    public int? TotaalWerkzamePersonen { get; set; }

    [JsonPropertyName("statutaireNaam")]
    public string? StatutaireNaam { get; set; }

    [JsonPropertyName("handelsnamen")]
    public List<Handelsnamen> Handelsnamen { get; set; }

    [JsonPropertyName("sbiActiviteiten")]
    public List<SbiActiviteiten> SbiActiviteiten { get; set; }

    [JsonPropertyName("_links")]
    public Links Links { get; set; }

    [JsonPropertyName("_embedded")]
    public Embedded Embedded { get; set; }
}

