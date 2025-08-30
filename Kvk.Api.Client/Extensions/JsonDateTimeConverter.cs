using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Extensions;

/// <summary>
/// A flexible JSON converter for <see cref="DateTime"/> values that allows
/// specifying a custom date format string (e.g. "yyyyMMdd", "yyyy-MM-dd").
/// </summary>
internal sealed class JsonDateTimeConverter : JsonConverter<DateTime>
{
    private readonly string Format = "yyyyMMdd";

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonDateTimeConverter"/> class
    /// with the specified format.
    /// </summary>
    /// <param name="format">The custom date format string (e.g. "yyyyMMdd").</param>
    public JsonDateTimeConverter(string format)
    {
        Format = format;
    }

    /// <summary>
    /// Reads a <see cref="DateTime"/> value from JSON, expecting the date string
    /// to match the configured format.
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
    /// formatted according to the configured format.
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The <see cref="DateTime"/> value to write.</param>
    /// <param name="options">Serializer options (not used).</param>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}