using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Data
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public Guid Token { get; set; }
        public Guid UserGuid { get; set; }
        public string ErrorMessage { get; set; }
        public int Balance { get; set; }
    }
}
