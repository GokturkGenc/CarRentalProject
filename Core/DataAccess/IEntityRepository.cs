    using Core.DataAccess.EntityFramework;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {   //her yeni sınıf için tekrar tekrar yazmak yerine bu arayüzü oluşturduk ve T değişkenini verdik
        //bu T değişkeni herhangi bi sınıfa IEntityRepository yi inheritance yaptığımızda belirlediğimiz 
        //değişken uzerinden buradaki bilgileri vermektedir (ICarDal, IBrandDal üzerinde olduğu gibi)
       
        
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}