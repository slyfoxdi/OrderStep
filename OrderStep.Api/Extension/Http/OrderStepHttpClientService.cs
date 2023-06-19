using OrderStep.Api.Extension.Helper;
using OrderStep.Domain.Extension.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Extension.Http
{
    internal class OrderStepHttpClientService : IHttpClientService
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

        public async Task<HttpResponseMessage> GetAsync(string responseUrl)
        {
            return await _GetAsync(UrlBuilder.BuildRequestUrl(_baseUrl, responseUrl)).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> GetAsync<TRequest>(string responseUrl, TRequest request)
        {
            return await _GetAsync(UrlBuilder.BuildRequestUrl(_baseUrl, responseUrl, request)).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PostAsync(HttpResponseMessage response)
        {
            throw new NotImplementedException();
        }

        private async Task<HttpResponseMessage> _GetAsync(string responseUrl)
        {
            using (var client = CreateHandler())
            {
                return await client.GetAsync(responseUrl).ConfigureAwait(false);
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
