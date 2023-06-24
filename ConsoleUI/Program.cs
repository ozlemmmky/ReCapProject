using Business.Concrete;
using ConsoleUI;
using DataAcces.Abstract;
using DataAcces.Concrete.EntitiyFramework;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI

{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            // CarTest();

            //ColorTest();
            //BrandTest();
            // CustomerAdd();
            //UserAdd();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental() { CarId=1,CustomerId=1,RentDate=DateTime.Now});
           // rentalManager.Add(new Rental() { CarId = 2, CustomerId = 3, RentDate = DateTime.Now,ReturnDate=DateTime.Today});





            //CarManager carManager = new CarManager(new EfCarDal());
            //{
            //    foreach(var car in carManager.GetCarDetail())
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.Description);
            //    }
            //}

        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User() { FirstName = "özlem", LastName = "kaya", Email = "ozlemkaya@gmail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "neslihan", LastName = "kaya", Email = "neslihankaya@gmail.com", Password = "123" });
            userManager.Add(new User() { FirstName = "emine", LastName = "kaya", Email = "eminekaya@gmail.com", Password = "123" });
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer() { UserId = 1, CompanyName = "Martı" });
            customerManager.Add(new Customer() { UserId = 4, CompanyName = "tatilköyü" });
            customerManager.Add(new Customer() { UserId = 3, CompanyName = "google" });
            customerManager.Add(new Customer() { UserId = 2, CompanyName = "Microsoft" });
        }

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBranDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            Car car = new Car() { BrandId = 1, ColorId = 2, ModelYear = 2020, DailyPrice = 500, Description = "son model araba" };
            carManager.Add(car);
        }
    }
}
