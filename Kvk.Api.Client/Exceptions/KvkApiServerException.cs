using System.Net;

namespace Kvk.Api.Client.Exceptions;

public class KvkApiServerException : KvkApiException
{
    public KvkApiServerException(string code, string description)
        : base(code, description, HttpStatusCode.InternalServerError)
    {
    }
}
