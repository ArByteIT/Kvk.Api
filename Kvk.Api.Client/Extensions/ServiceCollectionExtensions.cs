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
    /// Adds the Kvk API V1 client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The updated service collection.</returns>
    public static IHttpClientBuilder AddKvkApiV1Client(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<KvkOptions>(configuration.GetRequiredSection(KvkOptions.SectionName));

        services.AddTransient<KvkApiErrorHandler>();

        var productName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name ?? "KvkApiClient";
        var productVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0";

        // V1 Client
        services.AddTransient<IKvkApiV1Client, KvkApiV1Client>();
        return services.AddHttpClient(KvkOptions.HttpV1ClientName, (provider, client) =>
        {
            var options = provider.GetRequiredService<IOptions<KvkOptions>>().Value;

            client.BaseAddress = new Uri($"{options.BaseUrl}api/v1/");
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(productName, productVersion));
            client.DefaultRequestHeaders.Add("apikey", options.ApiKey);
        })
            .AddHttpMessageHandler<KvkApiErrorHandler>();
    }

    /// <summary>
    /// Adds the Kvk API V2 client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The updated service collection.</returns>
    public static IHttpClientBuilder AddKvkApiV2Client(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<KvkOptions>(configuration.GetRequiredSection(KvkOptions.SectionName));

        services.AddTransient<KvkApiErrorHandler>();

        var productName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name ?? "KvkApiClient";
        var productVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0";

        // V2 Client
        services.AddTransient<IKvkApiV2Client, KvkApiV2Client>();
        return services.AddHttpClient(KvkOptions.HttpV2ClientName, (provider, client) =>
        {
            var options = provider.GetRequiredService<IOptions<KvkOptions>>().Value;

            client.BaseAddress = new Uri($"{options.BaseUrl}api/v2/");
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(productName, productVersion));
            client.DefaultRequestHeaders.Add("apikey", options.ApiKey);
        })
            .AddHttpMessageHandler<KvkApiErrorHandler>();
    }
}
