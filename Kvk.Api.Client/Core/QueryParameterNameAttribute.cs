namespace Kvk.Api.Client.Core;

[AttributeUsage(AttributeTargets.Property)]
internal class QueryParameterNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
