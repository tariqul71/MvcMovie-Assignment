using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
namespace MvcMovie.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider services)
    {
        using var context = new MvcMovieContext(services.GetRequiredService<DbContextOptions<MvcMovieContext>>());
        if (context.Movie.Any()) return;
        context.Movie.AddRange(
            new Movie { Title="When Harry Met Sally", ReleaseDate=new DateTime(1989,2,12,0,0,0,DateTimeKind.Unspecified), Genre="Romantic Comedy", Price=7.99M, Rating="R" },
            new Movie { Title="Ghostbusters", ReleaseDate=new DateTime(1984,3,13,0,0,0,DateTimeKind.Unspecified), Genre="Comedy", Price=8.99M, Rating="PG" },
            new Movie { Title="Ghostbusters 2", ReleaseDate=new DateTime(1986,2,23,0,0,0,DateTimeKind.Unspecified), Genre="Comedy", Price=9.99M, Rating="PG" },
            new Movie { Title="Rio Bravo", ReleaseDate=new DateTime(1959,4,15,0,0,0,DateTimeKind.Unspecified), Genre="Western", Price=3.99M, Rating="PG" });
        context.SaveChanges();
    }
}
