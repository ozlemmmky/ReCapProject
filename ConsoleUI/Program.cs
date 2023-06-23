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

            CarManager carManager = new CarManager(new EfCarDal());
            {
                foreach(var car in carManager.GetCarDetail())
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.Description);
                }
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBranDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

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
