using Microsoft.EntityFrameworkCore;

namespace final.Models

{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options){

        }
    public DbSet<user> Users { get; set; }
    }
}