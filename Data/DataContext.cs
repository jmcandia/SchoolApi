using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Holder> Holders { get; set; }
        public DbSet<School> Schools { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}