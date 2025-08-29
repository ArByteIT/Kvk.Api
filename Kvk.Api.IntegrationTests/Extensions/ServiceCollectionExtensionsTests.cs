using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.Extensions;
using Kvk.Api.Client.Options;
using Kvk.Api.Client.V1;
using Kvk.Api.Client.V2.Zoeken;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Kvk.Api.IntegrationTests.Extensions;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddKvkClient_RegistersServicesCorrectly()
    {
        // Arrange
        var services = new ServiceCollection();

        // Simulate configuration
        Dictionary<string, string?>? inMemorySettings = new Dictionary<string, string?>
        {
            [$"{KvkOptions.SectionName}:BaseUrl"] = "https://api.kvk.nl/test/",
            [$"{KvkOptions.SectionName}:ApiKey"] = "testkey"
        };

        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        // Act
        services.AddKvkApiClient(configuration);

        var provider = services.BuildServiceProvider();

        // Assert KvkOptions configured
        var options = provider.GetRequiredService<IOptions<KvkOptions>>();
        Assert.Equal("https://api.kvk.nl/test/", options.Value.BaseUrl);
        Assert.Equal("testkey", options.Value.ApiKey);

        // Assert IKvkApiV1Client registered and resolves to KvkApiV1Client
        var kvkApiV1Client = provider.GetService<IKvkApiV1Client>();
        Assert.NotNull(kvkApiV1Client);
        Assert.IsType<KvkApiV1Client>(kvkApiV1Client);

        // Assert IKvkApiV2Client registered and resolves to KvkApiV2Client
        var kvkApiV2Client = provider.GetService<IKvkApiV2Client>();
        Assert.NotNull(kvkApiV2Client);
        Assert.IsType<KvkApiV2Client>(kvkApiV2Client);

        // Assert HttpV1ClientName configured with correct BaseAddress and ApiKey
        var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
        var httpV1Client = httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        Assert.Equal(new Uri("https://api.kvk.nl/test/api/v1/"), httpV1Client.BaseAddress);
        Assert.Equal("testkey", httpV1Client.DefaultRequestHeaders.FirstOrDefault(h => h.Key == "apikey").Value.FirstOrDefault());

        // Assert HttpV1ClientName configured with correct BaseAddress and ApiKey
        var httpV2Client = httpClientFactory.CreateClient(KvkOptions.HttpV2ClientName);
        Assert.Equal(new Uri("https://api.kvk.nl/test/api/v2/"), httpV2Client.BaseAddress);
        Assert.Equal("testkey", httpV2Client.DefaultRequestHeaders.FirstOrDefault(h => h.Key == "apikey").Value.FirstOrDefault());

        // Assert FixerApiErrorHandler registered in DI container
        var errorHandler = provider.GetService<KvkApiErrorHandler>();
        Assert.NotNull(errorHandler);
    }
}
