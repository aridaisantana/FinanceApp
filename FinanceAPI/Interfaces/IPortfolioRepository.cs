using FinanceAPI.Models;

namespace FinanceAPI.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);
    }
}
