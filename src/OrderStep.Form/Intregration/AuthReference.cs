using Newtonsoft.Json;
using OrderStep.Api.Helper;
using OrderStep.Api.Model;
using OrderStep.Api.Model.Request;
using OrderStep.Api.Model.Response;
using OrderStep.Domain.Extension.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Intregration
{
    public class AuthReference : IAuthReference
    {
        private readonly IHttpClientService _httpClientService;

        public AuthReference(IHttpClientService httpClientService) {
            _httpClientService = httpClientService;
        }

        /// <inheritdoc/>>
        public BaseResponse<Client> Authentification(string login, string password)
        {
            var request = new AuthRequest(login, PasswordCrypt.CreateMD5(password));
            var jsonObject = JsonConvert.SerializeObject(request);
            var result = _httpClientService.Post("api/Auth/Authentification", jsonObject);
            var content = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<BaseResponse<Client>>(content);

            return response;
        }
    }
}
