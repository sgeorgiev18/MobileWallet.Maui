using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Data
{
    public class RefreshToken2UserReq
    {
        public Guid? UserGuid { get; set; }
        public Guid? Token { get; set; }
    }
}
