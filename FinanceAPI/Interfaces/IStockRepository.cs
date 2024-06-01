using FinanceAPI.Dtos.Stock;
using FinanceAPI.Models;

namespace FinanceAPI.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id); //FirstOrDefault can be null
        Task<Stock> CreateAsync(Stock stockmodel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
