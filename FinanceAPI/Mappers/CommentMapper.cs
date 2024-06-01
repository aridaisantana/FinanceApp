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
                Title = commentModel.Title,
                Content = commentModel.Content,
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
