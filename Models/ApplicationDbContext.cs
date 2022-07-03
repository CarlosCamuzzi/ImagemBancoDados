using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace webImagemMvc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Image> Image { get; set; }       
              

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(ImageMap.Create());
        }
    }
}

