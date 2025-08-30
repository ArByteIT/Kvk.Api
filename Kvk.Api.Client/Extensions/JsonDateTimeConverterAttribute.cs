using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Extensions;

/// <summary>
/// A <see cref="JsonConverterAttribute"/> that allows specifying a custom
/// date format for <see cref="DateTime"/> or <see cref="DateTime?"/> properties.
/// When applied, it will use <see cref="JsonDateTimeConverter"/> with the given format.
/// </summary>
internal sealed class JsonDateTimeConverterAttribute : JsonConverterAttribute
{
    private readonly string _format;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonDateTimeConverterAttribute"/> class.
    /// </summary>
    /// <param name="format">The date format string to use for serialization and deserialization (e.g., "yyyyMMdd").</param>
    public JsonDateTimeConverterAttribute(string format)
    {
        _format = format;
    }

    /// <summary>
    /// Creates the converter instance for the target type.
    /// Only supports <see cref="DateTime"/> and <see cref="DateTime?"/>.
    /// </summary>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <returns>An instance of <see cref="JsonDateTimeConverter"/> for the specified format.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the attribute is applied to a type other than DateTime or Nullable<DateTime>.
    /// </exception>
    public override JsonConverter CreateConverter(Type typeToConvert)
    {
        if (typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?))
        {
            return new JsonDateTimeConverter(_format);
        }

        throw new InvalidOperationException($"JsonDateTimeConvertAttribute can only be applied to DateTime or Nullable<DateTime> properties, not {typeToConvert}.");
    }
}