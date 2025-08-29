namespace Kvk.Api.Client.Options;

public class KvkOptions
{
    public const string SectionName = "Kvk";
    public const string HttpV1ClientName = "KvkV1";
    public const string HttpV2ClientName = "KvkV2";

    public string BaseUrl { get; set; } = "https://api.kvk.nl/api/";
    public string? ApiKey { get; set; } = string.Empty;
}
