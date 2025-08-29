using System.Net;

namespace Kvk.Api.Client.Exceptions;

public class KvkApiNotFoundException : KvkApiException
{
    public KvkApiNotFoundException(string code, string description)
        : base(code, description, HttpStatusCode.NotFound)
    {
    }
}
