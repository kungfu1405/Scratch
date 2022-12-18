using Microsoft.EntityFrameworkCore;
using System.Data;
using WebMvc.Models;

namespace WebMvc.Data
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }    
    }
}
