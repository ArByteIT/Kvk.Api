using Kvk.Api.Client.Extensions;
using System.Text.Json;

namespace Kvk.Api.IntegrationTests.Extensions;

public class DateTimeYyyyMMddConverterTests
{
    private readonly JsonSerializerOptions _options;

    public DateTimeYyyyMMddConverterTests()
    {
        _options = new JsonSerializerOptions
        {
            Converters = { new DateTimeYyyyMMddConverter() }
        };
    }

    private class TestModel
    {
        public DateTime Datum { get; set; }
    }

    [Fact]
    public void Deserialize_ValidYyyyMMdd_ReturnsCorrectDate()
    {
        // Arrange
        var json = @"{ ""Datum"": ""20240131"" }";

        // Act
        var result = JsonSerializer.Deserialize<TestModel>(json, _options);

        // Assert
        Assert.Equal(new DateTime(2024, 1, 31), result!.Datum);
    }

    [Fact]
    public void Serialize_DateTime_WritesYyyyMMddString()
    {
        // Arrange
        var model = new TestModel { Datum = new DateTime(2024, 1, 31) };

        // Act
        var json = JsonSerializer.Serialize(model, _options);

        // Assert
        Assert.Contains(@"""Datum"":""20240131""", json);
    }

    [Fact]
    public void Deserialize_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        var json = @"{ ""Datum"": ""31-01-2024"" }";

        // Act & Assert
        Assert.Throws<FormatException>(() =>
            JsonSerializer.Deserialize<TestModel>(json, _options));
    }
}