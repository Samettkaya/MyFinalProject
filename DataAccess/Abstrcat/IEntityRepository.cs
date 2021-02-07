﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrcat
{
    // generic constraint
    // class: referans tip 
    // IEntity: IEntity olabilir veya IEntity implement eden bir nesene olabilir 
    // new() : new'lenebilir olmalı 
    public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

   
    }
}