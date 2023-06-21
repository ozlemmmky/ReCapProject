using DataAcces.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntitiyFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarsContext carsContext= new CarsContext())
            {
                var addedCar= carsContext.Entry(entity);
                addedCar.State= EntityState.Added; 
                carsContext.SaveChanges();
                Console.WriteLine("Added" + entity.Description);

            }
        }

        public void Delete(Car entity)
        {
           
            using(CarsContext carsContext= new CarsContext())
            {
                var deletedCars= carsContext.Entry(entity);
                deletedCars.State= EntityState.Deleted;
                carsContext.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarsContext carsContext = new CarsContext())
            {
                return filter == null ?
                carsContext.Set<Car>().ToList() :
                carsContext.Set<Car>().Where(filter).ToList();

            }

        }
        public void Update(Car entity)
        {
            using (CarsContext carsContext = new CarsContext())
            {
                var updatedCar= carsContext.Entry(entity);
                updatedCar.State= EntityState.Modified;
                carsContext.SaveChanges();

            }
        }
    }
}
