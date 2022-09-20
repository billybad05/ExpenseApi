using Microsoft.EntityFrameworkCore;
using ExpenseApi.Models;

namespace ExpenseApi.Models {

    public class AppDbContext : DbContext {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expenseline> Expenselines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<ExpenseApi.Models.Employee> Employee { get; set; }

    }
}
