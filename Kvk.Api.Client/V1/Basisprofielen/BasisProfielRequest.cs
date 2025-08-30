using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class BasisProfielRequest
{
    /// <summary>
    /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
    /// Vereist veld.
    public required string KvkNummer { get; set; }

    /// <summary>
    /// Optioneel. Indien <c>true</c>, wordt geo-locatie informatie van de eigenaar meegeleverd.
    /// </summary>
    [QueryParameterName("geoData")]
    public bool? GeoData { get; set; }
}
