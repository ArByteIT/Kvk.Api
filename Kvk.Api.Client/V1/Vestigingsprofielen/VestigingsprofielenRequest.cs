using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1.Vestigingsprofielen;

public class VestigingsprofielenRequest
{
    public required string Vestigingsnummer { get; set; }

    [QueryParameterName("geoData")]
    public bool? GeoData { get; set; }
}
