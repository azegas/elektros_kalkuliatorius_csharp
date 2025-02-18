using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class CheckContext : DbContext
{
    public CheckContext(DbContextOptions<CheckContext> options)
        : base(options)
    { 
    }

    public DbSet<CheckItem> CheckItems { get; set; } = null!;
}
