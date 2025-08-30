using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Extensions;

/// <summary>
/// A JSON converter for <see cref="DateTime"/> values that enforces the format "yyyyMMdd".
/// Useful when interacting with APIs that expect dates as compact numeric strings
/// (e.g., 20250830 for August 30, 2025).
/// </summary>
internal sealed class DateTimeYyyyMMddConverter : JsonConverter<DateTime>
{
    private readonly string Format = "yyyyMMdd";

    /// <summary>
    /// Reads a <see cref="DateTime"/> value from JSON, expecting it
    /// to be represented as a string in "yyyyMMdd" format.
    /// </summary>
    /// <param name="reader">The JSON reader.</param>
    /// <param name="typeToConvert">The type being converted (ignored here).</param>
    /// <param name="options">Serializer options (not used).</param>
    /// <returns>The parsed <see cref="DateTime"/>.</returns>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        return DateTime.ParseExact(str!, Format, null);
    }

    /// <summary>
    /// Writes a <see cref="DateTime"/> value to JSON as a string
    /// formatted in "yyyyMMdd".
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The <see cref="DateTime"/> value to write.</param>
    /// <param name="options">Serializer options (not used).</param>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}
