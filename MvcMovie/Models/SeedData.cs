using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
      {
        // Look for any movies.
        if (context.Movie.Any())
        {
          return;   // DB has been seeded
        }

        context.Movie.AddRange(
             new Movie
             {
               Title = "President Russell M. Nelson: Brilliant Mind, Gentle Hearty",
               ReleaseDate = DateTime.Parse("2018-10-11"),
               Genre = "Documentary",
               Rating = "G",
               Price = 12.99M
             },

             new Movie
             {
               Title = "Studio C Greatest Sketches ",
               ReleaseDate = DateTime.Parse("2017-12-30"),
               Genre = "Comedy",
               Rating = "PG",
               Price = 14.99M
             },

             new Movie
             {
               Title = "Other Side of Heaven",
               ReleaseDate = DateTime.Parse("2003-2-21"),
               Genre = "Drama",
               Rating = "PG",
               Price = 9.99M
             },

           new Movie
           {
             Title = "Johny Lingo",
             ReleaseDate = DateTime.Parse("1969-4-16"),
             Genre = "Comedy",
             Rating = "G",
             Price = 2.99M
           },

           new Movie
           {
             Title = "Christmas Apron",
             ReleaseDate = DateTime.Parse("2018-11-5"),
             Genre = "Christmas",
             Rating = "G",
             Price = 7.99M
           },

           new Movie
           {
             Title = "Trek: The Movie",
             ReleaseDate = DateTime.Parse("2018-6-10"),
             Genre = "Drama",
             Rating = "PG",
             Price = 12.99M
           }
        );
        context.SaveChanges();
      }
    }
  }
}