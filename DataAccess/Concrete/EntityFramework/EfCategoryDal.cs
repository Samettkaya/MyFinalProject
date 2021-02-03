using DataAccess.Abstrcat;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        void IEntityRepository<Category>.Add(Category entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Category>.Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        Category IEntityRepository<Category>.Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Category> IEntityRepository<Category>.GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Category>.Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
