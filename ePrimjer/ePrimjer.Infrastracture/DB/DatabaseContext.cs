using ePrimjer.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrimjer.Infrastracture
{
    public partial class DatabaseContext: DbContext
    {

        public DatabaseContext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<Student> students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
            
        }
        
        public override int SaveChanges()
        {            
            TimeStamp();
            return base.SaveChanges();
        }

        private void TimeStamp()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (
                   e.State == EntityState.Added
                   || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
                }
                else if (entityEntry.State == EntityState.Modified)
                    ((BaseEntity)entityEntry.Entity).ModifiedAt = DateTime.UtcNow;
            }

        }
    }

  
}
