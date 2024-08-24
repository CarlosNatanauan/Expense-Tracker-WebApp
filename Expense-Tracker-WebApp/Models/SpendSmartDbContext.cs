using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker_WebApp.Models
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) : base(options)
        {

        }
    }
}
