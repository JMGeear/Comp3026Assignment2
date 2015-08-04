namespace Comp3026Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VirtuosoModels : DbContext
    {
        public VirtuosoModels()
            : base("name=VirtuosoModels")
        {
        }

        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Brands>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brands)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.FirstMidName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);
        }
    }
}
