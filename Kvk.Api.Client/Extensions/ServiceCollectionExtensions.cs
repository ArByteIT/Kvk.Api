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
    /// Registers both the Kvk API V1 and V2 clients in the service collection.
    /// </summary>
    /// <param name="services">The service collection to extend.</param>
    /// <param name="configuration">The application configuration used for Kvk options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddKvkApiClients(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddKvkApiV1Client(configuration);

        services.AddKvkApiV2Client(configuration);

        return services;
    }

    /// <summary>
    /// Registers the Kvk API V1 client and its dependencies in the service collection.
    /// Configures <see cref="KvkOptions"/> from configuration, 
    /// adds the <see cref="KvkApiErrorHandler"/> message handler,
    /// and registers a named <see cref="HttpClient"/> with base address and headers.
    /// </summary>
    /// <param name="services">The service collection to extend.</param>
    /// <param name="configuration">The application configuration used for Kvk options.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> for further client configuration.</returns>
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
    /// Registers the Kvk API V2 client and its dependencies in the service collection.
    /// Configures <see cref="KvkOptions"/> from configuration, 
    /// adds the <see cref="KvkApiErrorHandler"/> message handler,
    /// and registers a named <see cref="HttpClient"/> with base address and headers.
    /// </summary>
    /// <param name="services">The service collection to extend.</param>
    /// <param name="configuration">The application configuration used for Kvk options.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> for further client configuration.</returns>
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
