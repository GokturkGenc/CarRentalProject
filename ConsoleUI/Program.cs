using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //DailyPriceTest();

            //BrandAndId();

            //GetUserNames();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            {
                foreach (var rental in rentalManager.GetAll().Data)
                {
                    Console.WriteLine(rental.RentDate);
                }
            }

        }

        private static void GetUserNames()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + "    " + user.LastName);
            }
        }

        private static void BrandAndId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " / " + car.Id);
            }
        }

        private static void DailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " \t " + car.Id);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }


}
