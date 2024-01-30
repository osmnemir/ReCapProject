using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFremework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarwindContext>, IRentalDal
    {
        public Rental findRental(int id)
        {
            throw new NotImplementedException();
        }

        public Rental GetRentalCarIdOrderByDESCReturnDate(Car Car)
        {
            throw new NotImplementedException();
        }
    }
}
