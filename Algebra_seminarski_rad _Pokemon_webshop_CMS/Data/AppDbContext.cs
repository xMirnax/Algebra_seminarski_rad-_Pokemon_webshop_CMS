using Microsoft.EntityFrameworkCore;

namespace Algebra_seminarski_rad__Pokemon_webshop_CMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
