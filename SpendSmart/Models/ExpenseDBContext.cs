using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class ExpenseDBContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseDBContext(DbContextOptions<ExpenseDBContext> options) : base(options)
        {
            
        }
    }
}
