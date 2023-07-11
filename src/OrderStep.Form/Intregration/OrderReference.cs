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
    internal class OrderReference : IOrderReference
    {
        private readonly IHttpClientService _httpClientService;

        public OrderReference(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        /// <inheritdoc/>>
        public BaseResponse<int> GetFreeOrderId()
        {
            var result = _httpClientService.Get("api/Order/GetFreeOrderId");
            var content = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<BaseResponse<int>>(content);

            return response;
        }

        /// <inheritdoc/>>
        public BaseResponse<bool> SaveOrder(List<OrderRequest> order)
        {
            var result = _httpClientService.Get("api/Order/SaveOrder", order);
            var content = result.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<BaseResponse<bool>>(content);

            return response;
        }
    }
}
