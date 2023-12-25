using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Data
{
    internal class APIs
    {
        public const string AuthenticateUser = "/api/v1/login";
        public const string RegisterUser = "/api/v1/register";
        public const string CreateToken = "/api/v1/createtoken";
        public const string CheckToken = "/api/v1/checktoken";
        public const string RefreshToken = "/api/v1/refreshtoken";
    }
}
