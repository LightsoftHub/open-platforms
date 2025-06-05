using System;
using System.Collections.Generic;

namespace Light.Lazada.Common
{
    public static class LazadaExtensions
    {
        public static string ToLazDate(this DateTimeOffset value)
        {
            return value.ToString("yyyy-MM-dd'T'HH:mm:ssK");
        }
        public static string ToLazDate(this DateTimeOffset? value)
        {
            return value.Value.ToString("yyyy-MM-dd'T'HH:mm:ssK");
        }

        public static string Join(this IEnumerable<string> list) => string.Join(",", list);
    }
}
