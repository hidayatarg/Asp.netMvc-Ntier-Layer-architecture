using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstruct;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        //Tum Liste Donduren
       
        public List<Product> GetALL(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //TODO duzeltilecektir
                return context.Products.ToList();
            }
        }
        //Id verdimiz product gostersin /verdimiz filter gore dondurur
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(filter);
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        //Guncellem Operasiyon
        public void Update(Product product)
        {

        }

        //Delete Operasiyon
        public void Delete(Product product)
        {

        }
    }
}
