namespace Kvk.Api.Client.Core;

/// <summary>
/// Specifies the name to use for a property when it is converted
/// into a query string parameter by <see cref="QueryParameterBuilder"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryParameterNameAttribute(string name) : Attribute
{
    /// <summary>
    /// Gets the query parameter name that should be used for the decorated property.
    /// </summary>
    public string Name { get; } = name;
}
