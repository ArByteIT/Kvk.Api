using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class HeeftGewijzigdeGegevens
{
    [JsonPropertyName("deponeringen")]
    public Deponeringen Deponeringen { get; set; }

    [JsonPropertyName("eigenaar")]
    public Eigenaar Eigenaar { get; set; }

    [JsonPropertyName("functionarissen")]
    public Functionarissen Functionarissen { get; set; }

    [JsonPropertyName("maOnderneming")]
    public MaOnderneming MaOnderneming { get; set; }

    [JsonPropertyName("vestigingen")]
    public GewijzigdeVestigingenVestigingen Vestigingen { get; set; }
}
