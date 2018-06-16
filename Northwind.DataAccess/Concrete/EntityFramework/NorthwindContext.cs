using System.Data.Entity;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
