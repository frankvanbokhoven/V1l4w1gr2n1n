using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOAuth
{
    public class UserAuthorization
    {
        public string AccessToken
        {
            get { return AuthorizationState.AccessToken; }
        }

        public string RefreshToken { get; set; }

        public IAuthorizationState AuthorizationState { get; set; }
    }
}
