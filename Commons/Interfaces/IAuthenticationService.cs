using System.Threading.Tasks;

using Commons.Models;

namespace Commons.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticatedUser> AuthenticateAsync(Credentials credentials);
        Task<AuthenticatedUser> RefreshAsync(Token token);
    }
}