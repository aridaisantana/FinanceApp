﻿using FinanceAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinanceAPI.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
