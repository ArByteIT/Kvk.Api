using Kvk.Api.Client.Extensions;
using Kvk.Api.Client.Options;
using Kvk.Api.Client.V1;
using Kvk.Api.Client.V2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvk.Api.IntegrationTests;

public class BaseTests
{
    protected readonly IKvkApiV1Client _kvkApiV1Client;
    protected readonly IKvkApiV2Client _kvkApiV2Client;

    public BaseTests()
    {
        DotNetEnv.Env.Load();

        var baseUrl = Environment.GetEnvironmentVariable("KVK_BASE_URL");
        var apiKey = Environment.GetEnvironmentVariable("KVK_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new InvalidOperationException("Set KVK_API_KEY environment variable before running tests.");

        var services = new ServiceCollection();
        Dictionary<string, string?>? inMemorySettings = new Dictionary<string, string?>
        {
            [$"{KvkOptions.SectionName}:BaseUrl"] = baseUrl,
            [$"{KvkOptions.SectionName}:ApiKey"] = apiKey
        };

        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        // Act
        services.AddKvkApiClient(configuration);

        var provider = services.BuildServiceProvider();

        _kvkApiV1Client = provider.GetRequiredService<IKvkApiV1Client>();
        _kvkApiV2Client = provider.GetRequiredService<IKvkApiV2Client>();
    }
}
