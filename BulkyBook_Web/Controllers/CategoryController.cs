using BulkyBook_Web.Data;
using BulkyBook_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook_Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
