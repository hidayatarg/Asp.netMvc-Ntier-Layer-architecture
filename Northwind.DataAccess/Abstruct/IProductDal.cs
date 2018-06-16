using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstruct
{
    //Gerekli olan operasiyonlari burda yazariz
   public interface IProductDal
   {
       //Tum Liste Donduren
        List<Product> GetALL();

       //Id verdimiz product gostersin
       Product Get(int id);

       //Ekleme Operasiyon
       void Add(Product product);

       //Guncellem Operasiyon
       void Update(Product product);
       

       //Delete Operasiyon
       void Delete(Product product);


   }
}
