[![Kvk.Api.Client Nuget](https://img.shields.io/nuget/v/ArByte.Kvk.Api.Client.svg?style=flat)](https://www.nuget.org/packages/Kvk.Api.Client)
![.NET Integration Tests](https://github.com/ArbyteIt/Kvk.Api/actions/workflows/dotnet-integration-tests.yml/badge.svg)

# Kvk.Api.Client

Een eenvoudige, sterk getypeerde en configureerbare .NET API-client voor de [Kvk API](https://developers.kvk.nl) bedrijfsregistratie-API.
Ondersteunt zoeken, basisprofiel, vestigingsprofiel, naamgeving en mutatieservice met ingebouwde foutverwerking en eenvoudige DI-integratie.

---

## Features

- Automatische foutverwerking met expliciete uitzonderingen voor API-fouten
- Ondersteunt annuleringstokens voor asynchrone aanroepen
- Eenvoudige integratie met `IHttpClientFactory` en Dependency Injection
- Inclusief integratietests om API-interacties te verifiëren

---

## Installatie

Install de NuGet package met:

```bash
dotnet add package ArByte.Kvk.Api.Client
````

---

## Getting Started

### Registratie van de cliënt

Configureer uw services in `Startup.cs` of waar DI configureert wordt:

```csharp
// Registreer alle Kvk API clients:
services.AddKvkApiClients(Configuration.GetSection("Kvk"));

// Of registreer afzonderlijk:
services.AddKvkApiV1Client(Configuration.GetSection("Kvk"));
services.AddKvkApiV2Client(Configuration.GetSection("Kvk"));
```

Uw configuratie moet minimaal het volgende bevatten:

```json
{
  "Kvk": {
    "ApiKey": "your_api_key_here"
  }
}
```

---

### Gebruiksvoorbeeld

Injecteer `IKvkApiV1Client` of `IKvkApiV2Client` in een service of controller:

```csharp
public class KvkService
{
    private readonly IKvkApiV2Client _kvkApiV2Client;

    public KvkService(IKvkApiV2Client kvkApiV2Client)
    {
        _kvkApiV2Client = kvkApiV2Client;
    }

    public async Task PrintCompanyNameAsync(string kvkNummer, CancellationToken cancellationToken = default)
    {
        var request = new ZoekRequest()
        {
            KvkNummer = kvkNummer,
        };

        var response = await _kvkApiV2Client.ZoekenAsync(request, cancellationToken);

        foreach (var resulaat in response.Resultaten)
        {
            Console.WriteLine($"{resulaat.KvkNummer}: {resulaat.Naam}");
        }
    }
}
```

---

## Foutafhandeling

API-fouten gooien expliciete uitzonderingen af die afgeleid zijn van KvkApiException, zoals:

* `KvkApiBadRequestException` (400)
* `KvkApiNotFoundException` (404)
* `KvkApiServerException` (500)
* En andere volgens de [Kvk IPD codes](https://developers.kvk.nl/nl/documentation#status-codes).

Gebruik try-catch-blokken om deze op een nette manier af te handelen.

---

## Testen

Inclusief integratietests met xUnit om het gedrag van de live API te verifiëren.
Configureer je `KVK_API_KEY` omgevingsvariabele voordat je de tests uitvoert.

---

## Bijdragen

Bijdragen zijn welkom! Open issues of pull requests.

---

## Licentie

Dit project is gelicentieerd onder de MIT-licentie – zie het [LICENSE](LICENSE) bestand voor details.

---

## Links

* [Kvk API Documentation](https://developers.kvk.nl/documentation)
* [NuGet Package](https://www.nuget.org/packages/ArByte.Kvk.Api.Client)