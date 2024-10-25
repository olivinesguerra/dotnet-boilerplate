using System.Threading.Tasks;

namespace Commons.Interfaces
{
    public interface IPasswordHasher
    {
        Task<string> HashAsync(string value);
        Task<bool> ValidateHashAsync(string raw, string hash);
    }
}