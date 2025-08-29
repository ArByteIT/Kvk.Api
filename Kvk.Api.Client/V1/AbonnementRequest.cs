using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1;

public class AbonnementRequest
{
    public required string AbonnementId { get; set; }
    [QueryParameterName("vanaf")]
    public DateTime? VanafDatum { get; set; }
    [QueryParameterName("tot")]
    public DateTime? TotEnMetDatum { get; set; }
    [QueryParameterName("pagina")]
    public int? Pagina { get; set; }
    [QueryParameterName("aantal")]
    public int? Aantal { get; set; }
}
