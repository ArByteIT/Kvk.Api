using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class Hoofdvestiging
{
    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("rsin")]
    public string? Rsin { get; set; }

    [JsonPropertyName("indNonMailing")]
    public string? IndNonMailing { get; set; }

    [JsonPropertyName("formeleRegistratiedatum")]
    public string? FormeleRegistratiedatum { get; set; }

    [JsonPropertyName("materieleRegistratie")]
    public MaterieleRegistratie MaterieleRegistratie { get; set; }

    [JsonPropertyName("statutaireNaam")]
    public string? StatutaireNaam { get; set; }

    [JsonPropertyName("eersteHandelsnaam")]
    public string? EersteHandelsnaam { get; set; }

    [JsonPropertyName("indHoofdvestiging")]
    public string? IndHoofdvestiging { get; set; }

    [JsonPropertyName("indCommercieleVestiging")]
    public string? IndCommercieleVestiging { get; set; }

    [JsonPropertyName("voltijdWerkzamePersonen")]
    public int? VoltijdWerkzamePersonen { get; set; }

    [JsonPropertyName("totaalWerkzamePersonen")]
    public int? TotaalWerkzamePersonen { get; set; }

    [JsonPropertyName("deeltijdWerkzamePersonen")]
    public int? DeeltijdWerkzamePersonen { get; set; }

    [JsonPropertyName("handelsnamen")]
    public List<Handelsnamen> Handelsnamen { get; set; } = new List<Handelsnamen>();

    [JsonPropertyName("adressen")]
    public List<Adressen> Adressen { get; set; } = new List<Adressen>();

    [JsonPropertyName("websites")]
    public List<string> Websites { get; set; } = new List<string>();

    [JsonPropertyName("sbiActiviteiten")]
    public List<SbiActiviteiten> SbiActiviteiten { get; set; } = new List<SbiActiviteiten>();

    [JsonPropertyName("_links")]
    public Links Links { get; set; }
}

