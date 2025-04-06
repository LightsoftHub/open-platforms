using Light.Shopee.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Light.Shopee.Models
{
    public class BaseRequest
    {
        public Dictionary<string, object> QueryParameters { get; private set; } = new Dictionary<string, object>();

        public string UrlQuery => "&" + QueryParameters.ToQueryString();

        public void Add(string key, object value) => QueryParameters[key] = value;

        public void Add<T>(Expression<Func<T>> expr)
        {
            var body = expr.Body as MemberExpression;
            string varName = body?.Member.Name ?? "unknown";
            T value = expr.Compile().Invoke();

            Add(varName, value);
        }

        public static BaseRequest Create<T>(Expression<Func<T>> expr)
        {
            var request = new BaseRequest();
            request.Add(expr);
            return request;
        }
    }
}
