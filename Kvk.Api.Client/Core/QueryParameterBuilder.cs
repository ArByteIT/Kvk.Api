namespace Kvk.Api.Client.Core;

/// <summary>
/// Utility for building query strings from objects with properties
/// decorated by <see cref="QueryParameterNameAttribute"/>.
/// </summary>
internal sealed class QueryParameterBuilder
{
    /// <summary>
    /// Converts the public properties of an object into a query string.
    /// Only properties decorated with <see cref="QueryParameterNameAttribute"/>
    /// and having non-null values are included.
    /// </summary>
    /// <param name="obj">The object whose properties are converted.</param>
    /// <param name="prefix">The prefix to use before the query string (default is "?").</param>
    /// <returns>A query string starting with <paramref name="prefix"/>.</returns>
    public static string ToQueryString(object obj, string prefix = "?")
    {
        var properties = obj.GetType().GetProperties();
        var parameters = new List<string>();

        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            if (value != null)
            {
                QueryParameterNameAttribute? attribute = property.GetCustomAttributes(typeof(QueryParameterNameAttribute), false).FirstOrDefault() as QueryParameterNameAttribute;
                string? key = attribute?.Name;
                string? val = value.ToString();

                if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(val))
                {
                    continue;
                }

                parameters.Add($"{key}={Uri.EscapeDataString(val)}");
            }
        }
        
        return prefix + string.Join('&', parameters);
    }
}
