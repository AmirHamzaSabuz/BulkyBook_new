using BulkyBook_DataAccess.Data;
using BulkyBook_DataAccess.Repository.IRepository;
using BulkyBook_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook_DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

    }
}
