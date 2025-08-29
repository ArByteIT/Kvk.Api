using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Extensions;

public class DateTimeYyyyMMddConverter : JsonConverter<DateTime>
{
    private readonly string Format = "yyyyMMdd";

    public DateTimeYyyyMMddConverter(string format)
    {
        Format = format;
    }

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        return DateTime.ParseExact(str!, Format, null);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}
