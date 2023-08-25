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
                    new Product() {ProductName="Photo Camera", Price=1000},
                    new Product() {ProductName="Webcam", Price=200},
                    new Product() {ProductName="Hang Bag", Price=500},
                    new Product() {ProductName="Sofa", Price=3000},
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