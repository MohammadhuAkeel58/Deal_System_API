using DealAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DealAPI.Data
{
    public class DealsDbContext : DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public DealsDbContext(DbContextOptions<DealsDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Entity<Deal>()
                .HasMany(d => d.Hotels)        
                .WithOne(h => h.Deal)         
                .HasForeignKey(h => h.DealId)  
                .OnDelete(DeleteBehavior.Cascade);  
        }





    }
}