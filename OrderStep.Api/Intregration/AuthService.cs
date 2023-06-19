using Newtonsoft.Json;
using OrderStep.Api.Model;
using OrderStep.Api.Model.Request;
using OrderStep.Domain.Extension.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Intregration
{
    internal class AuthService : IAuthService
    {
        private readonly IHttpClientService _httpClientService;

        public AuthService(IHttpClientService httpClientService) {
            _httpClientService = httpClientService;
        }

        public async Task<Client> Authentification(string login, string password)
        {
            var request = new AuthRequest(login, password);
            var result = await _httpClientService.GetAsync("api/Auth/Authentification", request);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Client>(content);
        }
    }
}
