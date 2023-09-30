using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(
                repository
                .GetAll() //DÖnüş değeri IQueryable olduğundan kayıtlar db'den çekilmeden filtreleme yapılıp sonra kayıtlar çekiliyor. Eğer dönüş değeri IEnumerable olsaydı önce tüm kayıtlar dbden çekilip sonra filtreleme yapılacaktı ve bir anlamı olmayacaktı.
                .Where(i=>i.ProductId==id)
                .Include(i=>i.Images) //include ile farklı tablodan veri çekiyoruz.
                .Include(i=>i.Attributes)
                .Include(i=>i.ProductCategories) //burda önce ProductCategories tablosuna bağlanıp onun üzerinden de ThenInclude ile Category leri çekiyoruz.
                .ThenInclude(i=>i.Category)
                .Select(i=> new ProductDetailsModel()
                {
                    Product = i,
                    ProductImages = i.Images,
                    ProductAttributes = i.Attributes,
                    Categories = i.ProductCategories.Select(a=>a.Category).ToList()
                })
                .FirstOrDefault()
            );
        }
    }
}