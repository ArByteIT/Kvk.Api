namespace Kvk.Api.Client.Core;

public class QueryParameterBuilder
{
    public static string ToQueryString(object obj)
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
        
        return string.Join('&', parameters);
    }
}
