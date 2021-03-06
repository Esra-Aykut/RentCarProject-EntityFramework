
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    /*---Generic Constraint---
    class   => Bir referans tip olmalı. 
    IEntity => IEntity veya onu implemente etmiş bir nesne   
    new()   => newlenebilir olmalı. 
    */
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

    }
}

