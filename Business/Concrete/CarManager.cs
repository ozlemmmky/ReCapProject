using Business.Abstract;
using DataAcces.Abstract;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal= carDal;    
        }

        public void Add(Car car )
        {

            if (car.Description.Length >= 2)
            {
                if(car.DailyPrice>0)
                {
                    _carDal.Add(car);
                }
            }
            
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
