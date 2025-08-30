using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V2.Zoeken;

/// <summary>
/// Represents a search request for the KVK API ("Zoeken").
/// All properties are optional and correspond to query parameters in the API.
/// </summary>
public class ZoekRequest
{
    /// <summary>
    /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers.
    /// </summary>
    [QueryParameterName("kvkNummer")]
    public string? KvkNummer { get; set; }

    /// <summary>
    /// Rechtspersonen Samenwerkingsverbanden Informatie Nummer (RSIN), 9 cijfers.
    /// </summary>
    [QueryParameterName("rsin")]
    public string? Rsin { get; set; }

    /// <summary>
    /// Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers.
    /// </summary>
    [QueryParameterName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    /// <summary>
    /// De naam waaronder een vestiging of rechtspersoon handelt.
    /// </summary>
    [QueryParameterName("naam")]
    public string? Naam { get; set; }

    /// <summary>
    /// Straatnaam van het adres van de vestiging.
    /// </summary>
    [QueryParameterName("straatnaam")]
    public string? Straatnaam { get; set; }

    /// <summary>
    /// Plaats van het adres van de vestiging.
    /// </summary>
    [QueryParameterName("plaats")]
    public string? Plaats { get; set; }

    /// <summary>
    /// Postcode van het adres. Mag alleen in combinatie met huisnummer worden gebruikt.
    /// </summary>
    [QueryParameterName("postcode")]
    public string? Postcode { get; set; }

    /// <summary>
    /// Huisnummer van het adres. Mag alleen in combinatie met postcode worden gebruikt.
    /// </summary>
    [QueryParameterName("huisnummer")]
    public int? Huisnummer { get; set; }

    /// <summary>
    /// Optioneel. Huisletter of toevoeging bij het huisnummer.
    /// </summary>
    [QueryParameterName("huisletter")]
    public string? Huisletter { get; set; }

    /// <summary>
    /// Postbusnummer, indien van toepassing.
    /// </summary>
    [QueryParameterName("postbusnummer")]
    public int? Postbusnummer { get; set; }

    /// <summary>
    /// Filter op type: hoofdvestiging, nevenvestiging en/of rechtspersoon.
    /// </summary>
    [QueryParameterName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Inclusief inactieve registraties: true of false.
    /// </summary>
    [QueryParameterName("inclusiefInactieveRegistraties")]
    public bool? InclusiefInactieveRegistraties { get; set; }

    /// <summary>
    /// Paginanummer, minimaal 1 en maximaal 1000.
    /// </summary>
    [QueryParameterName("pagina")]
    public int? Pagina { get; set; }

    /// <summary>
    /// Kies het aantal resultaten per pagina, minimaal 1 en maximaal 100.
    /// </summary>
    [QueryParameterName("resultatenPerPagina")]
    public int? ResultatenPerPagina { get; set; }
}