using FinanceAPI.Dtos.Comment;
using FinanceAPI.Models;

namespace FinanceAPI.Interfaces
{
    public interface ICommentRepository
    {
        Task <List<Comment>> GetAllAsync();
        Task <Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment?> UpdateAsync(int id, UpdateCommentRequestDto requestDto);
        Task<Comment?> DeleteAsync(int id);
    }
}
