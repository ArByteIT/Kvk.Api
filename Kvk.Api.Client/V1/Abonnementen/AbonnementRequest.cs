using Kvk.Api.Client.Core;

namespace Kvk.Api.Client.V1.Abonnementen;

/// <summary>
/// Geef een lijst van alle signalen, gepagineerd en gebaseerd op de vanaf parameter
/// </summary>
public class AbonnementRequest
{
    public required string AbonnementId { get; set; }

    [QueryParameterName("vanaf")]
    public DateTime? VanafDatum { get; set; }

    [QueryParameterName("tot")]
    public DateTime? TotEnMetDatum { get; set; }

    /// <summary>
    /// Geeft aan welke pagina je op wilt vragen. Start vanaf pagina 1
    /// </summary>
    [QueryParameterName("pagina")]
    public int? Pagina { get; set; }

    /// <summary>
    /// Aantal zoekresultaten per pagina.
    /// </summary>
    [QueryParameterName("aantal")]
    public int? Aantal { get; set; }
}
