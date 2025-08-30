namespace Kvk.Api.Client.V1.Naamgevingen;

public class NaamgevingenRequest
{
    /// <summary>
    /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
    /// Vereist veld.
    public required string KvkNummer { get; set; }
}