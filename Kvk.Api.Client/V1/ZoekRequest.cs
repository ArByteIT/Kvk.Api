using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1;

public class ZoekRequest
{
    [QueryParameterName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [QueryParameterName("rsin")]
    public string? Rsin { get; set; }

    [QueryParameterName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [QueryParameterName("handelsnaam")]
    public string? Handelsnaam { get; set; }

    [QueryParameterName("straatnaam")]
    public string? Straatnaam { get; set; }

    [QueryParameterName("plaats")]
    public string? Plaats { get; set; }

    [QueryParameterName("postcode")]
    public string? Postcode { get; set; }

    [QueryParameterName("huisnummer")]
    public int? Huisnummer { get; set; }

    [QueryParameterName("huisnummerToevoeging")]
    public string? HuisnummerToevoeging { get; set; }

    [QueryParameterName("type")]
    public string? Type { get; set; }

    [QueryParameterName("InclusiefInactieveRegistraties")]
    public bool? InclusiefInactieveRegistraties { get; set; }

    [QueryParameterName("pagina")]
    public int? Pagina { get; set; }

    [QueryParameterName("aantal")]
    public int? Aantal { get; set; }
}