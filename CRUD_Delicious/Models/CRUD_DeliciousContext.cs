using Microsoft.EntityFrameworkCore;

namespace CRUD_Delicious.Models
{
    public class CRUD_DeliciousContext : DbContext
    {
        public CRUD_DeliciousContext(DbContextOptions options) : base(options) { }
        public DbSet<DishModel> Dishes { get; set; }
    }
}