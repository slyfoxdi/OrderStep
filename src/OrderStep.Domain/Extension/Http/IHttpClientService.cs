using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Extension.Http
{
    internal interface IHttpClientService
    {
        Task<HttpResponseMessage> GetAsync();

        Task<HttpResponseMessage> PostAsync(HttpResponseMessage response);
    }
}
