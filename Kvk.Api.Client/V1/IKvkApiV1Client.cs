namespace Kvk.Api.Client.V1;

public interface IKvkApiV1Client
{
    Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default);

    Task<BasisProfiel> GetBasisprofiel(string kvkNummer, CancellationToken cancellationToken = default);
    Task<BasisprofielEigenaar> GetBasisprofielEigenaar(string kvkNummer, CancellationToken cancellationToken = default);
    Task<BasisprofielHoofdvestiging> GetBasisprofielHoofdvestiging(string kvkNummer, CancellationToken cancellationToken = default);
    Task<BasisprofielVestigingen> GetBasisprofielVestigingen(string kvkNummer, CancellationToken cancellationToken = default);

    Task<List<Abonnement>> GetAbonnementen(CancellationToken cancellationToken = default);
    Task<Abonnement> GetAbonnement(string abo, CancellationToken cancellationToken = default);
    Task<AbonnementSignalen> GetAbonnementSignalen(string abo, CancellationToken cancellationToken = default);

    Task<Vestigingsprofielen> GetVestigingsprofielen(string kvkNummer, CancellationToken cancellationToken = default);
    Task<Naamgevingen> GetNaamgevingen(string kvkNummer, CancellationToken cancellationToken = default);
}
