using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.Options;
using Kvk.Api.Client.V1;
using Kvk.Api.Client.V2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace Kvk.Api.Client.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds the Kvk API client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddKvkApiClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<KvkOptions>(configuration.GetRequiredSection(KvkOptions.SectionName));
        services.AddTransient<KvkApiErrorHandler>();

        // V1 Client
        services.AddTransient<IKvkApiV1Client, KvkApiV1Client>();
        services.AddHttpClient(KvkOptions.HttpV1ClientName, (provider, client) =>
        {
            var options = provider.GetRequiredService<IOptions<KvkOptions>>().Value;
            client.BaseAddress = new Uri($"{options.BaseUrl}api/v1/");
            // client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("apikey", options.ApiKey);
        })
            .AddHttpMessageHandler<KvkApiErrorHandler>();

        // V2 Client
        services.AddTransient<IKvkApiV2Client, KvkApiV2Client>();
        services.AddHttpClient(KvkOptions.HttpV2ClientName, (provider, client) =>
        {
            var options = provider.GetRequiredService<IOptions<KvkOptions>>().Value;
            client.BaseAddress = new Uri($"{options.BaseUrl}api/v2/");
            // client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("apikey", options.ApiKey);
        })
            .AddHttpMessageHandler<KvkApiErrorHandler>();

        return services;
    }
}
