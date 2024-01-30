using DataAccess.Abstract;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=150,Description="Toyota",ModelYear=2015},
                new Car {CarId=2,BrandId=2,ColorId=1,DailyPrice=200,Description="Megane",ModelYear=2005},
                new Car {CarId=3,BrandId=3,ColorId=2,DailyPrice=100,Description="Nissan",ModelYear=2020},
                new Car {CarId=4,BrandId=4,ColorId=3,DailyPrice=350,Description="Mustang",ModelYear=2017},
                new Car {CarId=5,BrandId=2,ColorId=3,DailyPrice=250,Description="Clio",ModelYear=2018}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
           
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
           
            _cars.Remove(carToDelete);
 
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        { // gönderdiğim ,ürün ıd sine sahip olan listedeki ıd sini bul
          Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description=car.Description;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c=> c.BrandId == BrandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
