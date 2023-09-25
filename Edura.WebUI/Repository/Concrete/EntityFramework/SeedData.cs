using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraContext>();

            context.Database.Migrate(); //bekleyen migration'ları çalıştırır. cmd'de 'dotnet ef database update' ile aynı işlevi görüyor.

            if (!context.Products.Any())
            {
                var products = new []
                {
                    new Product() {ProductName="Photo Camera", Price=1000, Image="product1.jpg", IsApproved=true, IsHome=true, IsFeatured=true},
                    new Product() {ProductName="Wood Chair", Price=200, Image="product2.jpg", IsApproved=true, IsHome=false, IsFeatured=true},
                    new Product() {ProductName="Comfortable Sofa", Price=500, Image="product3.jpg", IsApproved=true, IsHome=true, IsFeatured=false},
                    new Product() {ProductName="Hang Bag", Price=500, Image="product4.jpg", IsApproved=false, IsHome=true, IsFeatured=true},
                    new Product() {ProductName="Sofa", Price=3000, Image="product3.jpg", IsApproved=false, IsHome=false, IsFeatured=false},
                };

                context.Products.AddRange(products);

                var categories = new []
                {
                    new Category() {CategoryName="Electronics"},
                    new Category() {CategoryName="Accessories"},
                    new Category() {CategoryName="Furniture"}
                };

                context.Categories.AddRange(categories);

                var productCategories = new []
                {
                    new ProductCategory() {Product=products[0], Category=categories[0]},
                    new ProductCategory() {Product=products[1], Category=categories[0]},
                    new ProductCategory() {Product=products[2], Category=categories[1]},
                    new ProductCategory() {Product=products[3], Category=categories[2]}
                };

                context.AddRange(productCategories);

                context.SaveChanges(); //bütün işlemler db'ye kaydediliyor.
            }
        }
    }
}