using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repository;
        private IUnitOfWork _uow;
        public HomeController(IUnitOfWork uow, IProductRepository repository)
        {
            _repository = repository;
            _uow = uow;
        }
        public IActionResult Index()
        {
            //return View(_repository.GetAll()); //repository üzerinden yani IProductRepository üzerinden tüm ürünleri döndürme
            return View(_uow.Products.GetAll()); //unit of work üzerinden tüm product'ları döndürme. unit of work sayesinde her class için ayrı bir dbcontext oluşturmak yerine tüm class'lar tek bir dbContext üzerinden çalıştırılıyor.
        }

        public IActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }

        public IActionResult Create()
        {
            var product = new Product() {ProductName="New Product", Price=250};

            _uow.Products.Add(product);

            _uow.SaveChanges();

            return RedirectToAction("Index");
         }
    }
}