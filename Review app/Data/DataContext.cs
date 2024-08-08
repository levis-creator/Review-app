using Microsoft.EntityFrameworkCore;
using Review_app.Models;

namespace Review_app.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokomon> Pokomons { get; set; }
        public DbSet<PokomonOwner> PokomonOwners { get; set; }  
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers {  get; set; }
        public DbSet<PokomonCategory> PokomonCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this is declaring relationships keys
            modelBuilder.Entity<PokomonCategory>().HasKey(pc => new { pc.CategoryId, pc.PokomonId });
            modelBuilder.Entity<PokomonCategory>()
                .HasOne(p => p.Pokomon)
                .WithMany(pc => pc.PokomonCategories)
                .HasForeignKey(c => c.PokomonId);
            modelBuilder.Entity<PokomonCategory>()
               .HasOne(p => p.Category)
               .WithMany(pc => pc.PokomonCategories)
               .HasForeignKey(c => c.CategoryId);
            //Pokomon owner  junction Table
            modelBuilder.Entity<PokomonOwner>().HasKey(po => new { po.OwnerId, po.PokomonId });
            modelBuilder.Entity<PokomonOwner>()
                .HasOne(p => p.Owner)
                .WithMany(po => po.PokomonOwners)
                .HasForeignKey(po => po.OwnerId);

            modelBuilder.Entity<PokomonOwner>()
                .HasOne(p => p.Pokomon)
                .WithMany(po => po.PokomonOwners)
                .HasForeignKey(po => po.PokomonId);


        }


    }
}
