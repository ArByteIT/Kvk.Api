using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V2;

public class ZoekRequest
{
    [QueryParameterName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [QueryParameterName("rsin")]
    public string? Rsin { get; set; }

    [QueryParameterName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [QueryParameterName("naam")]
    public string? Naam { get; set; }

    [QueryParameterName("straatnaam")]
    public string? Straatnaam { get; set; }

    [QueryParameterName("plaats")]
    public string? Plaats { get; set; }

    [QueryParameterName("postcode")]
    public string? Postcode { get; set; }

    [QueryParameterName("huisnummer")]
    public int? Huisnummer { get; set; }

    [QueryParameterName("huisletter")]
    public string? Huisletter { get; set; }

    [QueryParameterName("postbusnummer")]
    public int? Postbusnummer { get; set; }

    [QueryParameterName("type")]
    public string? Type { get; set; }

    [QueryParameterName("inclusiefInactieveRegistraties")]
    public bool? InclusiefInactieveRegistraties { get; set; }

    [QueryParameterName("pagina")]
    public int? Pagina { get; set; }

    [QueryParameterName("resultatenPerPagina")]
    public int? ResultatenPerPagina { get; set; }
}
