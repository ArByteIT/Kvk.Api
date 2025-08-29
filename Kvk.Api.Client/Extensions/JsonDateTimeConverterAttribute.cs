using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Extensions;

public class JsonDateTimeConverterAttribute : JsonConverterAttribute
{
    private readonly string _format;

    public JsonDateTimeConverterAttribute(string format)
    {
        _format = format;
    }

    public override JsonConverter CreateConverter(Type typeToConvert)
    {
        if (typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?))
        {
            return new DateTimeYyyyMMddConverter(_format);
        }

        throw new InvalidOperationException($"JsonDateTimeConvertAttribute can only be applied to DateTime or Nullable<DateTime> properties, not {typeToConvert}.");
    }
}