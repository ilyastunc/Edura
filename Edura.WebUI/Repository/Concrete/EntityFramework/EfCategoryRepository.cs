using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context):base(context) //base'e yani EfGenericRepository'e context olarak EduraContext tipindeki context'i gönderiyoruz. Normalde base'de context'in tipi DbContext
        {
            
        }

        public EduraContext EduraContext //bununla base'deki context'i EduraContext tipinde gönderilmesini sağlıyoruz. Böylece aşağıdaki gibi bu class'ta EduraContext'i kullanıyoruz.
        {
            get { return context as EduraContext;}
        }
        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(i=>i.CategoryName==name).FirstOrDefault();
        }
    }
}