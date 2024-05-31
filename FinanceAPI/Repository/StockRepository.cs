using FinanceAPI.Data;
using FinanceAPI.Dtos.Stock;
using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceAPI.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;

        public StockRepository(ApplicationDBContext context)
        { 
            _context = context;
        }

        public async Task<Stock> CreateAsync(Stock stockmodel)
        {
            await _context.Stocks.AddAsync(stockmodel);
            await _context.SaveChangesAsync();
            return stockmodel;
        }

        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(stock => stock.Id == id);
            
            if (stockModel == null) 
                return null;

            _context.Stocks.Remove(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
            
        }

        public async Task<List<Stock>> GetAllAsync()
        {
           return await _context.Stocks.ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.FindAsync(id);
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(stock => stock.Id == id);

            if (stockModel == null)
                return null;

            _context.Entry(stockModel).CurrentValues.SetValues(stockDto);
            await _context.SaveChangesAsync();

            return stockModel;
        }
    }
}
