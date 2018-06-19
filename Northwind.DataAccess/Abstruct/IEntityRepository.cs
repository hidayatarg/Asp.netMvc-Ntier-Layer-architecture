using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstruct
{
   public interface IEntityRepository<T>
    {
        //Tum Liste Donduren
        List<T> GetALL();

        //Id verdimiz product gostersin
        T Get(int id);

        //Ekleme Operasiyon
        void Add(T entity);

        //Guncellem Operasiyon
        void Update(T entity);


        //Delete Operasiyon
        void Delete(T entity);

    }
}
