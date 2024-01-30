using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntitiyFremework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            // RentalTest();
             UserTest();
            // BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }
        private static void UserTest()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { UserId = 1, FirstName = "Tomris", LastName = "EMİR",
                Password = "TOMRIS", Email = "tomrısemır@gmail.com" });
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.UserId + " : " + item.FirstName + " " + item.LastName);
            }
        }
        private static void RentalTest()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { RentalId = 1, CustomerId = 1, CarId = 3, RentDate = DateTime.Now });
            Console.WriteLine(result.Message);

            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.RentalId + " : " + item.CustomerId + " " + item.CarId + " " + item.RentDate);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "  " + car.BrandName + "  " + car.ColorName + "  " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
