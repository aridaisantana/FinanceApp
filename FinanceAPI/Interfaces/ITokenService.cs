using FinanceAPI.Models;

namespace FinanceAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
