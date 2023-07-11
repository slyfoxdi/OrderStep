using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Extension.Http
{
    public interface IHttpClientService
    {
        HttpResponseMessage Get(string responseUrl);

        HttpResponseMessage Get<TRequest>(string responseUrl, TRequest request);

        HttpResponseMessage PostAsync(HttpResponseMessage response);
    }
}
