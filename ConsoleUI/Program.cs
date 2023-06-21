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
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            Car car = new Car() {BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=500,Description="son model araba"};
            carManager.Add(car);



            

        }
    }
}
