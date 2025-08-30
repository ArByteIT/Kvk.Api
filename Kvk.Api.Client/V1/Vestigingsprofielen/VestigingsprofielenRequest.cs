using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1.Vestigingsprofielen;

public class VestigingsprofielenRequest
{
    /// <summary>
    /// Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers
    /// </summary>
    public required string Vestigingsnummer { get; set; }

    /// <summary>
    /// GeoData: (true/false) geef aan of BAG data opgehaald moet worden
    /// </summary>
    [QueryParameterName("geoData")]
    public bool? GeoData { get; set; }
}
