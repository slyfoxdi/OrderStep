using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Helper
{
    /// <summary>
    /// Хелпер по построению URL запроса
    /// </summary>
    public static class UrlBuilder
    {
        /// <summary>
        /// Создает URL
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="resourceUri"></param>
        /// <returns></returns>
        public static string BuildRequestUrl(string baseUri, string resourceUri)
        {
            var baseUrl = baseUri.EndsWith("/") ? baseUri.TrimEnd('/') : baseUri;
            var resourceUrl = resourceUri.StartsWith("/") ? resourceUri : "/" + resourceUri;
            return baseUrl + resourceUrl;
        }

        public static string BuildRequestUrl(string baseUri, string resourceUri, object requestObject)
        {
            return BuildRequestUrl(baseUri, resourceUri) + BuildQueryString(requestObject);
        }

        private static string BuildQueryString(object obj)
        {
            var properties = obj.GetType().GetProperties();
            var queryParams = new List<string>();

            foreach (var property in properties)
            {
                var name = property.Name;
                var value = property.GetValue(obj);

                if (value != null && name != null)
                    queryParams.AddRange(GetParamString(name, value));

            }

            return "?" + string.Join("&", queryParams);
        }

        private static IEnumerable<string> GetParamString(string name, object value)
        {
            if (!(value is string) && value is System.Collections.IEnumerable arrayValue)
            {
                var result = new List<string>();
                foreach (var item in arrayValue)
                {
                    result.Add(name + "=" + item.ToString());
                }

                return result;
            }

            return new[] { name + "=" + value.ToString() };
        }
    }
}
