using FinanceAPI.Dtos.Comment;
using FinanceAPI.Models;

namespace FinanceAPI.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.AppUser.UserName,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentFromRequestDto(this CreateCommentRequestDto commentRequestDto, int stockId)
        {
            return new Comment
            {
                Content = commentRequestDto.Content,
                Title = commentRequestDto.Title,
                StockId = stockId,
            };
        }
    }
}
