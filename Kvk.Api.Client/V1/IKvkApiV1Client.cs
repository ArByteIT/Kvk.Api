using Kvk.Api.Client.V1.Abonnementen;
using Kvk.Api.Client.V1.Basisprofielen;
using Kvk.Api.Client.V1.Naamgevingen;
using Kvk.Api.Client.V1.Vestigingsprofielen;
using Kvk.Api.Client.V1.Zoeken;

namespace Kvk.Api.Client.V1;

/// <summary>
/// Clientinterface voor de KVK API V1.
/// Biedt functionaliteit om te zoeken naar bedrijven en vestigingen, basisprofielen op te halen,
/// abonnementen te beheren en vestigingsprofielen en naamgevingen te raadplegen.
/// </summary>
public interface IKvkApiV1Client
{
    /// <summary>
    /// Zoekt naar bedrijven of rechtspersonen op basis van de opgegeven zoekcriteria.
    /// Geeft een gepagineerde <see cref="ZoekResponse"/> terug met maximaal 1000 resultaten.
    /// </summary>
    /// <param name="request">Het <see cref="ZoekRequest"/> object met optionele zoekfilters.</param>
    /// <param name="cancellationToken">Token om het verzoek te annuleren.</param>
    /// <returns>
    /// Een taak die resulteert in een <see cref="ZoekResponse"/> met de zoekresultaten,
    /// of <c>null</c> als er geen resultaten zijn gevonden.
    /// </returns>
    Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt het basisprofiel van een onderneming op.
    /// </summary>
    Task<BasisProfielResponse?> GetBasisprofielAsync(BasisProfielRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt de eigenaar(s) van het basisprofiel op.
    /// </summary>
    Task<BasisprofielEigenaarResponse?> GetBasisprofielEigenaarAsync(BasisprofielEigenaarRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt het basisprofiel van de hoofdvestiging van een onderneming op.
    /// </summary>
    Task<BasisprofielHoofdvestigingResponse?> GetBasisprofielHoofdvestigingAsync(BasisprofielHoofdvestigingRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt de vestigingen van het basisprofiel van een onderneming op.
    /// </summary>
    Task<BasisprofielVestigingenResponse?> GetBasisprofielVestigingenAsync(BasisprofielVestigingenRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Geef een lijst terug van alle actieve abonnementen van de klant
    /// </summary>
    Task<AbonnementenResponse?> GetAbonnementenAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Geef een lijst van alle signalen, gepagineerd en gebaseerd op de vanaf parameter
    /// </summary>
    Task<AbonnementResponse?> GetAbonnementAsync(AbonnementRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt de signalen van een abonnement op.
    /// </summary>
    Task<AbonnementSignalenResponse?> GetAbonnementSignalenAsync(AbonnementSignalenRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt de vestigingsprofielen van een onderneming op.
    /// </summary>
    Task<VestigingsprofielenResponse?> GetVestigingsprofielenAsync(VestigingsprofielenRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Haalt naamgevingen van een onderneming of vestiging op.
    /// </summary>
    Task<NaamgevingenResponse?> GetNaamgevingenAsync(NaamgevingenRequest request, CancellationToken cancellationToken = default);
}

