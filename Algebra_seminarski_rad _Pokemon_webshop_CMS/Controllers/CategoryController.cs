using Algebra_seminarski_rad__Pokemon_webshop_CMS.Data;
using Algebra_seminarski_rad__Pokemon_webshop_CMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Algebra_seminarski_rad__Pokemon_webshop_CMS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
