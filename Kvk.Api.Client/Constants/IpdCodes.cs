namespace Kvk.Api.Client.Constants;

/// <summary>
/// https://developers.kvk.nl/nl/documentation#status-codes
/// </summary>
public class IpdCodes
{
    /// <summary>
    /// Het gevraagde product {0}
    /// </summary>
    public const string IPD0001 = "IPD0001";
    /// <summary>
    /// Het KvK nummer {0} is niet valide.
    /// </summary>
    public const string IPD0004 = "IPD0004";
    /// <summary>
    /// Op basis van het KVK-nummer {0} kan het product niet worden geleverd.
    /// </summary>
    public const string IPD0005 = "IPD0005";
    /// <summary>
    /// Het vestigingsnummer {0} is niet valide.
    /// </summary>
    public const string IPD0006 = "IPD0006";
    /// <summary>
    /// Op basis van het vestigingsnummer {0} kan het product niet worden geleverd.
    /// </summary>
    public const string IPD0007 = "IPD0007";
    /// <summary>
    /// Het RSI-nummer {0} is niet valide.
    /// </summary>
    public const string IPD0010 = "IPD0010";
    /// <summary>
    /// De gegevens zijn tijdelijk niet leverbaar omdat deze in behandeling zijn. Probeer het later nog eens.
    /// </summary>
    public const string IPD1002 = "IPD1002";
    /// <summary>
    /// De gegevens zijn tijdelijk niet leverbaar. Probeer het over 5 minuten nog een keer. 
    /// </summary>
    public const string IPD1003 = "IPD1003";
    /// <summary>
    /// Algemene invoer parameter fout.
    /// </summary>
    public const string IPD1998 = "IPD1998";
    /// <summary>
    /// De volgende opgegeven parameter(s) is(zijn) ongeldig: {0}
    /// </summary>
    public const string IPD1999 = "IPD1999";
    /// <summary>
    /// Er zijn geen gegevens gevonden die voldoen aan de opgegeven zoekparameters.
    /// </summary>
    public const string IPD5200 = "IPD5200";
    /// <summary>
    /// Het opgegeven type is niet valide.
    /// </summary>
    public const string IPD5203 = "IPD5203";
    /// <summary>
    /// Algemene technische fout.
    /// </summary>
    public const string IPD9999 = "IPD9999";
}
