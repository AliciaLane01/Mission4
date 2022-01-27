using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    movieID = 1,
                    category = "Romantic Comedy",
                    title = "When in Rome",
                    year = "2010",
                    director = "Mark Steven Johnson",
                    rating = "PG-13"
                },
                new MovieResponse
                {
                    movieID = 2,
                    category = "Comedy/Family",
                    title = "Megamind",
                    year = "2010",
                    director = "Tom McGrath",
                    rating = "PG"
                },
                new MovieResponse
                {
                    movieID = 3,
                    category = "Action/Adventure",
                    title = "Captain America: The First Avenger",
                    year = "2011",
                    director = "Joe Johnston",
                    rating = "PG-13"
                }
            );
        }
    }
}
