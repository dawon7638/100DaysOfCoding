using CRUD_Delicious.Models;

namespace CRUD_Delicious.Controllers
{
    public class DishesController
    {
        private CRUD_DeliciousContext db;

        public DishesController(CRUD_DeliciousContext context)
        {
            db = context;
        }

        
    }
}