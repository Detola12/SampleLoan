using Microsoft.EntityFrameworkCore;
using TestLoan.Models.Entities;

namespace TestLoan.Data;

public class LoanContext : DbContext
{
    public LoanContext(DbContextOptions<LoanContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<LoanDetails> LoanDetails { get; set; }
    
}