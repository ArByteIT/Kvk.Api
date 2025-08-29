using System.Net;

namespace Kvk.Api.Client.Exceptions;

public class KvkApiBadRequestException : KvkApiException
{
    public KvkApiBadRequestException(string code, string description)
        : base(code, description, HttpStatusCode.BadRequest)
    {
    }
}
