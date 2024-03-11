


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using myblogef.Data.Config;
using myblogef.Models;

namespace myblogef.Data
{
    public class BlogDbContext :DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext>options): base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Customer> customers { get; set; }
                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new UserConfig());  
            base.OnModelCreating(modelBuilder);
        }
    }

   
}
