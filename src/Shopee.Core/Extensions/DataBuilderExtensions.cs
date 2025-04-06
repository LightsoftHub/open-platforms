using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Light.Shopee.Extensions
{
    public static class DataBuilderExtensions
    {
        public static long ToUnixTimeSeconds(this DateTime dateTime) =>
            new DateTimeOffset(dateTime).ToUnixTimeSeconds();

        public static string JoinToString(this IList<string> values) =>
            values != null && values.Any()
                ? string.Join(",", values)
                : string.Empty;

        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

        public static string ToQueryString(this Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            var queryParts = new List<string>();

            foreach (var kvp in parameters)
            {
                var key = Uri.EscapeDataString(kvp.Key);
                var value = kvp.Value;

                if (value == null)
                    continue;

                // Check if value is a string (which is IEnumerable but not a list for our purpose)
                if (value is string v)
                {
                    queryParts.Add($"{key}={Uri.EscapeDataString(v)}");
                }
                else if (value is DateTime dateTime)
                {
                    queryParts.Add($"{key}={ToUnixTimeSeconds(dateTime)}");
                }
                else if (value is IEnumerable enumerable)
                {
                    foreach (var item in enumerable)
                    {
                        if (item != null)
                        {
                            queryParts.Add($"{key}={Uri.EscapeDataString(item.ToString())}");
                        }
                    }
                }
                else
                {
                    // Single value (int, bool, etc.)
                    queryParts.Add($"{key}={Uri.EscapeDataString(value.ToString())}");
                }
            }

            return string.Join("&", queryParts);
        }
    }
}
