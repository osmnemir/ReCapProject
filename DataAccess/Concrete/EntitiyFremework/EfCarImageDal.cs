using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFremework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage , CarwindContext>, ICarImageDal
    {
    }
}
