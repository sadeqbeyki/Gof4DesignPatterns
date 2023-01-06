using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Specification;
//step 3

public class MovieContext : DbContext
{
    public DbSet<Movie> movies;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
