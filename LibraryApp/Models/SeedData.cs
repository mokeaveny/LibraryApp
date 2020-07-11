using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryApp.Data;
using System;
using System.Linq;

namespace LibraryApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return; // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Hunger Games",
                        Author = "Suzanne Collins",
                        Genre = "Teen",
                        Pages = 448,
                        ReleaseDate = DateTime.Parse("2008-09-14"),
                        FinishedReading = true
                    },
                    
                    new Book
                    {
                        Title = "A Game of Thrones",
                        Author = "George R.R. Martin",
                        Genre = "Fantasy",
                        Pages = 912,
                        ReleaseDate = DateTime.Parse("1996-08-01"),
                        FinishedReading = false
                    },

                    new Book
                    {
                        Title = "The Lord of the Rings",
                        Author = "J.R.R. Tolkien",
                        Genre = "Fantasy",
                        Pages = 1552,
                        ReleaseDate = DateTime.Parse("1954-07-29")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
