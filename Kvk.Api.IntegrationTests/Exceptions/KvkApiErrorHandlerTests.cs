using Kvk.Api.Client.Exceptions;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Kvk.Api.IntegrationTests.Exceptions;

public class KvkApiErrorHandlerTests : BaseTests
{
    [Theory]
    [InlineData(HttpStatusCode.BadRequest, typeof(KvkApiBadRequestException))]
    [InlineData(HttpStatusCode.NotFound, typeof(KvkApiNotFoundException))]
    [InlineData(HttpStatusCode.InternalServerError, typeof(KvkApiServerException))]
    [InlineData(HttpStatusCode.Forbidden, typeof(KvkApiException))] // fallback
    public async Task SendAsync_WithErrorResponse_ThrowsExpectedException(HttpStatusCode statusCode, Type expectedExceptionType)
    {
        // Arrange
        var error = new KvkError { Code = "ERR001", Omschrijving = "Test error" };
        var errorResponse = new KvkErrorResponse { Errors = [error] };
        var json = JsonSerializer.Serialize(errorResponse);

        var handler = new TestHandler(statusCode, json);
        var kvkHandler = new KvkApiErrorHandler { InnerHandler = handler };

        var client = new HttpClient(kvkHandler);

        // Act + Assert
        var ex = await Assert.ThrowsAsync(expectedExceptionType, () =>
            client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "http://localhost"))
        );
    }

    [Fact]
    public async Task SendAsync_WithMalformedJson_DoesNotThrow()
    {
        var malformedJson = "not a valid json";

        var handler = new TestHandler(HttpStatusCode.BadRequest, malformedJson);
        var kvkHandler = new KvkApiErrorHandler { InnerHandler = handler };

        var client = new HttpClient(kvkHandler);

        // Act
        var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "http://localhost"));

        // Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task SendAsync_WithEmptyErrors_DoesNotThrow()
    {
        var emptyErrorsJson = JsonSerializer.Serialize(new KvkErrorResponse { Errors = [] });

        var handler = new TestHandler(HttpStatusCode.BadRequest, emptyErrorsJson);
        var kvkHandler = new KvkApiErrorHandler { InnerHandler = handler };

        var client = new HttpClient(kvkHandler);

        // Act
        var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "http://localhost"));

        // Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    private sealed class TestHandler(HttpStatusCode statusCode, string content) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            Task.FromResult(new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            });
    }
}
