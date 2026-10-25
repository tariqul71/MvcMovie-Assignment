using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data;
public class MvcMovieContext(DbContextOptions<MvcMovieContext> options) : DbContext(options)
{
    public DbSet<Movie> Movie => Set<Movie>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().Property(m => m.ReleaseDate).HasColumnType("timestamp without time zone");
    }
}
