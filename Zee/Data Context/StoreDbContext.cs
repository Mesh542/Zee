using Microsoft.EntityFrameworkCore;
using Zee.Models;


namespace Zee.Data_Context
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }
    }
}
