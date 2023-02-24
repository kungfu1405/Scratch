using DbData.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData.Dal
{
    //internal class DbDataContext
    public class DbDataContext: DbContext
    {
        public DbDataContext(DbContextOptions<DbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { }
        public DbSet<ECity> Cities { get; set; }    
    }
  
}
