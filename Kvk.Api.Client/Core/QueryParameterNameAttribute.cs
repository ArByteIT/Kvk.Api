namespace Kvk.Api.Client.Core;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryParameterNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
