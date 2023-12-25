using MobileWallet.Maui.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Services
{
    public interface IAppService
    {
        public Task<LoginResponse> Authenticate(LoginModel loginModel);
        public Task<RegisterResponse> Register(RegisterModel registerModel);
    }
}
