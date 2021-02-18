using System;
using _02_Entities.Entities;
using _AppCore.DataAccess.Configs;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework
{
    public class OrderFromTableContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ProductTable> ProductTable { get; set; }

        public DbSet<Table> Table { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionConfig.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(category => category.Product)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Table>()
                .HasMany(Table => Table.ProductTable)
                .WithOne(ProductTable => ProductTable.Table)
                .HasForeignKey(ProductTable => ProductTable.TableId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(Product => Product.ProductTable)
                .WithOne(ProductTable => ProductTable.Product)
                .HasForeignKey(ProductTable => ProductTable.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Role>()
                .HasMany(Role => Role.User)
                .WithOne(User => User.Role)
                .HasForeignKey(User => User.RoleId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}