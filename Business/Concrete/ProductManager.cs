using Business.Abstract;
using DataAccess.Abstrcat;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kodları
            // yetkisi varmı 

            return _productDal.GetAll();
        }

        
    }
}
