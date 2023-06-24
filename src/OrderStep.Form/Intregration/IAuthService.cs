using OrderStep.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Intregration
{
    public interface IAuthService
    {
        BaseResponse<Client> Authentification(string login, string password);
    }
}
