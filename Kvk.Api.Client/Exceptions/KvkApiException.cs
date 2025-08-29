using System.Net;

namespace Kvk.Api.Client.Exceptions;

public class KvkApiException : Exception
{
    public string Code { get; }
    public string Description { get; }
    public HttpStatusCode HttpStatusCode { get; }

    public KvkApiException(string code, string description, HttpStatusCode httpStatusCode)
        : base($"KVK API request failed with code {code} status code {httpStatusCode} and description {description}")
    {
        HttpStatusCode = httpStatusCode;
        Code = code;
        Description = description;
    }
}
