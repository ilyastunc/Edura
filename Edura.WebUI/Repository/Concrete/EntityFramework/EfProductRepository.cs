using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository //IProductRepository'i ekstra methodlar için ekliyoruz. Mesela GetTop5Products() EfGenericRepository'nin içinde yok. IProductRepository'den geliyor
    {
        public EfProductRepository(EduraContext context):base(context)//base'e yani EfGenericRepository'e context olarak EduraContext tipindeki context'i gönderiyoruz. Normalde base'de context'in tipi DbContext
        {

        }

        public EduraContext EduraContext //bununla base'deki context'i EduraContext tipinde gönderilmesini sağlıyoruz. Böylece aşağıdaki gibi bu class'ta EduraContext'i kullanıyoruz.
        {
            get { return context as EduraContext;}
        }
        public List<Product> GetTop5Products()
        {
            return EduraContext.Products.OrderByDescending(i=>i.ProductId).Take(5).ToList();
        }
    }
}