using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car=new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=5000,Description="hyundai"},
                new Car{Id=2,BrandId=3,ColorId=1,ModelYear=2000,DailyPrice=1000,Description="Volvo"},
                new Car{Id=3,BrandId=1,ColorId=1,ModelYear=2022,DailyPrice=6000,Description="BMW"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=null;
            carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete); 
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            //Car carToGetById= null;
           // carToGetById = _car.Where(p => p.Id == id.ToL);
            return _car.Where(p => p.Id == id).ToList(); 
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate=_car.SingleOrDefault(p=>p.Id==car.Id);
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear; 
            carToUpdate.DailyPrice=car.DailyPrice;
          
        }
    }
}
