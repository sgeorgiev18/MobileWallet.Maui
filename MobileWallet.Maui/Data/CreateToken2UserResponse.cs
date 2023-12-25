using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Data
{
    public class CreateToken2UserResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public Guid? UserGuid { get; set; }
        public Guid? Token { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
    }
}
