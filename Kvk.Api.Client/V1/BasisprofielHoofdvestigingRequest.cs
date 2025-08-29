using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1;

public class BasisprofielHoofdvestigingRequest
{
    public required string KvkNummer { get; set; }
    [QueryParameterName("geoData")]
    public bool? GeoData { get; set; }
}
