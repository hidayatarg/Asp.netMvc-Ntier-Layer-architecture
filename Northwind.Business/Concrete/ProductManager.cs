using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstruct;
using Northwind.DataAccess.Abstruct;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    //icinde gerekli operasiyonlari yazacagim
   public class ProductManager:IProductService
    {
        // Yerinde Interface kullandik   IProductDal _productDal = new EfProductDal();
        private IProductDal _productDal;

        //Newlendinde bir iproductdal nesne ver
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //DataAccessLayer kullanmamiz lazim
            //Business code / IS kod yazilir cekilen data kisiye uygun mudur bu kodu yazdiktan sonra veri erisim katamana ulasmaya calisacagiz.
           
            return _productDal.GetALL();
        }
    }
}
