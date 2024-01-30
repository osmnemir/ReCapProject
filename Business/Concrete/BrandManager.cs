using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand Add(Brand Brand)
        {
            throw new NotImplementedException();
        }

        public Brand Delete(Brand Brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand Brand)
        {
            throw new NotImplementedException();
        }
    }
}
