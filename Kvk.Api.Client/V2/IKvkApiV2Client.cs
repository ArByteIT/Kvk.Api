namespace Kvk.Api.Client.V2;

public interface IKvkApiV2Client
{
    Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default);
}
