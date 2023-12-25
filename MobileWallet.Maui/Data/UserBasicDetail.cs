using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWallet.Maui.Data
{
    public class UserBasicDetail
    {
        public UserBasicDetail(Guid userGuid, Guid accessToken, string email, bool loggedIn, int balance)
        {
            UserGuid = userGuid;
            AccessToken = accessToken;
            Email = email;
            LoggedIn = loggedIn;
            Balance = balance;
        }

        public Guid UserGuid { get; set; }
        public Guid AccessToken { get; set; }
        public string Email { get; set; }
        public bool LoggedIn { get; set; } = false;
        public int Balance { get; set; } = 0;
    }
}
