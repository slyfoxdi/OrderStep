using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Helper
{
    public static class AuthOptions
    {
        public const string ISSUER = "OrderService"; // издатель токена
        public const string AUDIENCE = "VRKWeb"; // потребитель токена
        const string KEY = "asdn123*(AYSDUH@*Yh012i3hn01";   // ключ для шифрации
        public const int LIFETIME = 30; // время жизни токена - 1 минута

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
