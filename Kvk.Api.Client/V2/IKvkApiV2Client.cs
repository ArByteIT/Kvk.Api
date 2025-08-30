using Kvk.Api.Client.V2.Zoeken;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Clientinterface voor het KVK API V2 zoekendpoint ("Zoeken").
/// Biedt functionaliteit om te zoeken naar bedrijven, vestigingen of rechtspersonen
/// in de database van de Kamer van Koophandel.
/// </summary>
public interface IKvkApiV2Client
{
    /// <summary>
    /// Zoekt naar bedrijven of rechtspersonen op basis van de opgegeven zoekcriteria.
    /// Geeft een gepagineerde <see cref="ZoekResponse"/> terug met maximaal 1000 resultaten
    /// volgens de specificatie van de API.
    /// </summary>
    /// <param name="request">Het <see cref="ZoekRequest"/> object met optionele zoekfilters.</param>
    /// <param name="cancellationToken">Token om het verzoek te annuleren.</param>
    /// <returns>
    /// Een taak die resulteert in een <see cref="ZoekResponse"/> met de zoekresultaten,
    /// of <c>null</c> als er geen resultaten zijn gevonden.
    /// </returns>
    Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default);
}
