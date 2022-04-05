using AbhikumarsBooks.DataAccess.Repository.IRepository;
using AbhikumarsBooks.Models;
using AbhikumarsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhikumarsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            // use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the Category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = product.Name;
               
            }

        }
    }
}