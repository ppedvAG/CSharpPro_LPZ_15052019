using ppedv.FlyingPluto.Model;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ppedv.FlyingPluto.Data.EF
{
    public class EfContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Standort> Standorte { get; set; }
        public DbSet<Vermietung> Vermietungen { get; set; }

        public EfContext(string conStringOrName) : base(conStringOrName)
        { }

        public EfContext() : this("Server=.;Database=FlyingPluto_dev;Trusted_Connection=true;")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //System.Data.Entity.ModelConfiguration.Conventions.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Auto>().Property(x => x.Kennzeichen).IsRequired().HasMaxLength(27);

            modelBuilder.Entity<Vermietung>().HasRequired(x => x.AbholStandort).WithMany(x => x.Abhol).WillCascadeOnDelete(false);
            modelBuilder.Entity<Vermietung>().HasRequired(x => x.ZielStandort).WithMany(x => x.Ziel).WillCascadeOnDelete(false);


            modelBuilder.Types<Entity>().Configure(c =>
            {
                c.Property(x => x.Modified).HasColumnType("datetime2").IsConcurrencyToken();
                c.Property(x => x.Created).HasColumnType("datetime2");
            });
        }

        public override int SaveChanges()
        {
            DateTime now = DateTime.Now;
            foreach (var item in ChangeTracker.Entries<Entity>().Where(x => x.State == EntityState.Added))
            {
                item.Entity.Created = now;
                item.Entity.Modified = now;
            }
            foreach (var item in ChangeTracker.Entries<Entity>().Where(x => x.State == EntityState.Modified))
            {
                item.Entity.Modified = now;
            }

            return base.SaveChanges();
        }

    }
}
