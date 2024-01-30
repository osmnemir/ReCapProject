using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Concrete.EntitiyFremework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarwindContext>, ICarDal
    {
        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarwindContext context = new CarwindContext() )

            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             select new CarDetailDto { CarName = car.CarName, BrandName = brand.Name, 
                                 ColorName = color.Name, DailyPrice = car.DailyPrice };
                return result.ToList();

            }     
        }


    }
}

