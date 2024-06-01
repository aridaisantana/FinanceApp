﻿using FinanceAPI.Models;

namespace FinanceAPI.Interfaces
{
    public interface ICommentRepository
    {
        Task <List<Comment>> GetAllAsync();
        Task <Comment?> GetByIdAsync(int id);
    }
}