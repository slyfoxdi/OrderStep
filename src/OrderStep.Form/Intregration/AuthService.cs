using Newtonsoft.Json;
using OrderStep.Api.Extension.Helper;
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
    public class AuthService : IAuthService
    {
        private readonly IHttpClientService _httpClientService;

        public AuthService(IHttpClientService httpClientService) {
            _httpClientService = httpClientService;
        }

        public BaseResponse<Client> Authentification(string login, string password)
        {
            var request = new AuthRequest(login, PasswordCrypt.CreateMD5(password));
            var result = _httpClientService.Get("api/Auth/Authentification", request);
            var content = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<BaseResponse<Client>>(content);
            return response;
        }
    }
}
