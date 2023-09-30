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
                    new Product() {ProductName="Photo Camera", Price=1000, Image="product1.jpg", IsApproved=true, IsHome=true, IsFeatured=true, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus <b>PageMaker including versions of Lorem Ipsum.</b>", DateAdded=DateTime.Now.AddDays(-10)},
                    new Product() {ProductName="Wood Chair", Price=200, Image="product2.jpg", IsApproved=true, IsHome=false, IsFeatured=true, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus <b>PageMaker including versions of Lorem Ipsum.</b>", DateAdded=DateTime.Now.AddDays(-50)},
                    new Product() {ProductName="Comfortable Sofa", Price=500, Image="product3.jpg", IsApproved=true, IsHome=true, IsFeatured=false, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus <b>PageMaker including versions of Lorem Ipsum.</b>", DateAdded=DateTime.Now.AddDays(-5)},
                    new Product() {ProductName="Hang Bag", Price=500, Image="product4.jpg", IsApproved=false, IsHome=true, IsFeatured=true, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus <b>PageMaker including versions of Lorem Ipsum.</b>", DateAdded=DateTime.Now.AddDays(-2)},
                    new Product() {ProductName="Sofa", Price=3000, Image="product3.jpg", IsApproved=false, IsHome=false, IsFeatured=false, Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus <b>PageMaker including versions of Lorem Ipsum.</b>", DateAdded=DateTime.Now.AddDays(-30)},
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

                var images = new []
                {
                    new Image() {ImageName="product1.jpg", Product=products[0]},
                    new Image() {ImageName="product2.jpg", Product=products[0]},
                    new Image() {ImageName="product3.jpg", Product=products[0]},
                    new Image() {ImageName="product4.jpg", Product=products[0]},

                    new Image() {ImageName="product1.jpg", Product=products[1]},
                    new Image() {ImageName="product2.jpg", Product=products[1]},
                    new Image() {ImageName="product3.jpg", Product=products[1]},
                    new Image() {ImageName="product4.jpg", Product=products[1]},

                    new Image() {ImageName="product1.jpg", Product=products[2]},
                    new Image() {ImageName="product2.jpg", Product=products[2]},
                    new Image() {ImageName="product3.jpg", Product=products[2]},
                    new Image() {ImageName="product4.jpg", Product=products[2]},

                    new Image() {ImageName="product1.jpg", Product=products[3]},
                    new Image() {ImageName="product2.jpg", Product=products[3]},
                    new Image() {ImageName="product3.jpg", Product=products[3]},
                    new Image() {ImageName="product4.jpg", Product=products[3]},

                    new Image() {ImageName="product1.jpg", Product=products[4]},
                    new Image() {ImageName="product2.jpg", Product=products[4]},
                    new Image() {ImageName="product3.jpg", Product=products[4]},
                    new Image() {ImageName="product4.jpg", Product=products[4]}
                };

                context.Images.AddRange(images);

                var attribute = new[]
                {
                    new ProductAttribute() {Attribute="Display", Value="15.6", Product=products[0]},
                    new ProductAttribute() {Attribute="Processor", Value="Intel i7", Product=products[0]},
                    new ProductAttribute() {Attribute="RAM Memory", Value="8 GB", Product=products[0]},
                    new ProductAttribute() {Attribute="Hard Disk", Value="1 TB", Product=products[0]},
                    new ProductAttribute() {Attribute="Color", Value="Black", Product=products[0]},

                    new ProductAttribute() {Attribute="Display", Value="15.6", Product=products[1]},
                    new ProductAttribute() {Attribute="Processor", Value="Intel i7", Product=products[1]},
                    new ProductAttribute() {Attribute="RAM Memory", Value="8 GB", Product=products[1]},
                    new ProductAttribute() {Attribute="Hard Disk", Value="1 TB", Product=products[1]},
                    new ProductAttribute() {Attribute="Color", Value="Black", Product=products[1]},

                    new ProductAttribute() {Attribute="Display", Value="15.6", Product=products[2]},
                    new ProductAttribute() {Attribute="Processor", Value="Intel i7", Product=products[2]},
                    new ProductAttribute() {Attribute="RAM Memory", Value="8 GB", Product=products[2]},
                    new ProductAttribute() {Attribute="Hard Disk", Value="1 TB", Product=products[2]},
                    new ProductAttribute() {Attribute="Color", Value="Black", Product=products[2]},

                    new ProductAttribute() {Attribute="Display", Value="15.6", Product=products[3]},
                    new ProductAttribute() {Attribute="Processor", Value="Intel i7", Product=products[3]},
                    new ProductAttribute() {Attribute="RAM Memory", Value="8 GB", Product=products[3]},
                    new ProductAttribute() {Attribute="Hard Disk", Value="1 TB", Product=products[3]},
                    new ProductAttribute() {Attribute="Color", Value="Black", Product=products[3]},

                    new ProductAttribute() {Attribute="Display", Value="15.6", Product=products[4]},
                    new ProductAttribute() {Attribute="Processor", Value="Intel i7", Product=products[4]},
                    new ProductAttribute() {Attribute="RAM Memory", Value="8 GB", Product=products[4]},
                    new ProductAttribute() {Attribute="Hard Disk", Value="1 TB", Product=products[4]},
                    new ProductAttribute() {Attribute="Color", Value="Black", Product=products[4]}
                };

                context.Attributes.AddRange(attribute);

                context.SaveChanges(); //bütün işlemler db'ye kaydediliyor.
            }
        }
    }
}