using System;
using MangoServices.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoServices.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId= 1,
                Name= "Chontaduro",
                Price= 15,
                Description= "Delicious Chontaduro",
                ImageUrl= "https://dotnetmasteryleo.blob.core.windows.net/mango/chontaduro.jpeg",
                Category="Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Platano",
                Price = 15,
                Description = "Delicious Platano",
                ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/platano.jpeg",
                Category = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Mango",
                Price = 15,
                Description = "Delicious Mango",
                ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/mango.jpeg",
                Category = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pera",
                Price = 15,
                Description = "Delicious Pera",
                ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/pera.jpeg",
                Category = "Dessert"
            });
        }

    }
}

