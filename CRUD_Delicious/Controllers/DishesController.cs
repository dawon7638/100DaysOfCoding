using CRUD_Delicious.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Delicious.Controllers
{
    public class DishesController : Controller
    {
        private CRUD_DeliciousContext db;

        public DishesController(CRUD_DeliciousContext context)
        {
            db = context;
        }
        [HttpGet("/")]
        public IActionResult All()
        {
            return View("All");
        }

        [HttpGet("/new")]
        public IActionResult Add()
        {
            return View("Add");
        }
    }
    
}