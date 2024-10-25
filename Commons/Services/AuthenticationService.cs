using System.Linq;
using System.Threading.Tasks;

using Commons.Interfaces;
using Commons.Models;

namespace Commons.Services
{
    public class AuthenticationService : IAuthenticationService
    {   

        public AuthenticationService()
        {

        }

        public Task<AuthenticatedUser> AuthenticateAsync(Credentials credentials)
        {
            return null;
        }

        public Task<AuthenticatedUser> RefreshAsync(Token token)
        {
            return null;
        }

    }
}