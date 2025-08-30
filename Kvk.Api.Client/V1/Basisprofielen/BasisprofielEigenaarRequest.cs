using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class BasisprofielEigenaarRequest
{
    public required string KvkNummer { get; set; }

    [QueryParameterName("geoData")]
    public bool? GeoData { get; set; }
}
