using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //T referans tipi
    //bir sınırlama getiriyoruz
    interface IEntityRepostory<T>where T:class,IEntity,new()
        //buraya class olan IEntity den türemiş veya kendisi ve newlenebilir olmalı. Ientity newlenemez olduğu için artık sadece product gönderilir. 
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
