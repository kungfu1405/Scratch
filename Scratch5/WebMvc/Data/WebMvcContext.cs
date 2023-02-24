using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbData.Entity;
using Microsoft.EntityFrameworkCore;
using WebMvc.Models;

namespace WebMvc.Data
{
    public class WebMvcContext : DbContext
    {
        public WebMvcContext (DbContextOptions<WebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<WebMvc.Models.Movie> Movie { get; set; }
        public DbSet<ECity> Ecities { get; set; }
    }
}
