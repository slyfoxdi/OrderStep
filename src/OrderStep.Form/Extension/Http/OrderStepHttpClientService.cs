using OrderStep.Api.Helper;
using OrderStep.Domain.Extension.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Extension.Http
{
    public class OrderStepHttpClientService : IHttpClientService
    {
        private readonly string _baseUrl;
        private readonly string _login;
        private readonly string _password;

        public OrderStepHttpClientService(string baseUrl, string login, string password)
        {
            _baseUrl = baseUrl;
            _login = login;
            _password = password;  
        }

        public HttpResponseMessage Get(string responseUrl)
        {
            return _GetAsync(UrlBuilder.BuildRequestUrl(_baseUrl, responseUrl));
        }

        public HttpResponseMessage Get<TRequest>(string responseUrl, TRequest request)
        {
            return _GetAsync(UrlBuilder.BuildRequestUrl(_baseUrl, responseUrl, request));
        }

        public HttpResponseMessage Post(string responseUrl, string jsonObject)
        { 
            var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
            responseUrl = UrlBuilder.BuildRequestUrl(_baseUrl, responseUrl);

            using (var client = CreateHandler())
            {
                return client.PostAsync(responseUrl, content).ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }

        private HttpResponseMessage _GetAsync(string responseUrl)
        {
            using (var client = CreateHandler())
            {
                return client.GetAsync(responseUrl).ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }

        protected virtual HttpClient CreateHandler()
        {
            return new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; }
            });
        }
    }
}
