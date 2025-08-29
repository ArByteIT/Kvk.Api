using Kvk.Api.Client.V1.Abonnementen;
using Kvk.Api.Client.V1.Basisprofielen;
using Kvk.Api.Client.V1.Naamgevingen;
using Kvk.Api.Client.V1.Vestigingsprofielen;
using Kvk.Api.Client.V1.Zoeken;

namespace Kvk.Api.Client.V1;

public interface IKvkApiV1Client
{
    Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default);

    Task<BasisProfielResponse?> GetBasisprofielAsync(BasisProfielRequest request, CancellationToken cancellationToken = default);
    Task<BasisprofielEigenaarResponse?> GetBasisprofielEigenaarAsync(BasisprofielEigenaarRequest request, CancellationToken cancellationToken = default);
    Task<BasisprofielHoofdvestigingResponse?> GetBasisprofielHoofdvestigingAsync(BasisprofielHoofdvestigingRequest request, CancellationToken cancellationToken = default);
    Task<BasisprofielVestigingenResponse?> GetBasisprofielVestigingenAsync(BasisprofielVestigingenRequest request, CancellationToken cancellationToken = default);

    Task<AbonnementenResponse?> GetAbonnementenAsync(CancellationToken cancellationToken = default);
    Task<AbonnementResponse?> GetAbonnementAsync(AbonnementRequest request, CancellationToken cancellationToken = default);
    Task<AbonnementSignalenResponse?> GetAbonnementSignalenAsync(AbonnementSignalenRequest request, CancellationToken cancellationToken = default);

    Task<VestigingsprofielenResponse?> GetVestigingsprofielenAsync(VestigingsprofielenRequest request, CancellationToken cancellationToken = default);
    Task<NaamgevingenResponse?> GetNaamgevingenAsync(NaamgevingenRequest request, CancellationToken cancellationToken = default);
}
