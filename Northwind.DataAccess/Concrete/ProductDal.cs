using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete
{
    public class ProductDal
    {
        //Tum Liste Donduren
        public List<Product> GetALL()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        //Id verdimiz product gostersin
        public Product Get(int id)
        {
            using (NorthwindContext context= new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductID == id);
            }
        }

        //Ekleme Operasiyon
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
