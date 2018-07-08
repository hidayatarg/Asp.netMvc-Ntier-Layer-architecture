using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstruct;

namespace Northwind.DataAccess.Abstruct
{
   public interface IEntityRepository<T> 
       where T:class , IEntity, new ()
    {
        //Tum Liste Donduren
        List<T> GetALL(Expression<Func<T,bool>> filter=null);

        //Id verdimiz product gostersin
        T Get(Expression<Func<T, bool>> filter);

        //Ekleme Operasiyon
        void Add(T entity);

        //Guncellem Operasiyon
        void Update(T entity);


        //Delete Operasiyon
        void Delete(T entity);

    }
}
