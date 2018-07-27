using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstruct;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    //Nh Nhibernateten geliyor
   public class NhProductDal : IProductDal
    {
        public List<Product> GetALL(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    ProductId = 1,
                    ProductName = "iphone",
                    CategoryId = 1,
                    QuantityPerUnit = "1 in a Box",
                    UnitPrice = 213,
                    UnitsInStock = 23
                }

            };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

       

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
