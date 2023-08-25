using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Repository.Concrete
{
    public class EduraContext : DbContext
    {
        public EduraContext(DbContextOptions<EduraContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pk => new {pk.ProductId, pk.CategoryId}); //böylece model oluşturulduğunda ProductCategory'nin 2 tane primary key'i olacağını söylüyoruz. 
        }
    }
}