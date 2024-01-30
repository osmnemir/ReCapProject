using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        public Rental findRental(int id);
        public Rental GetRentalCarIdOrderByDESCReturnDate(Car Car);
    }
}
