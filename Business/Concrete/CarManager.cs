using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car )
        {

            if (car.Description.Length >= 2)
            {
                if(car.DailyPrice>0)
                {
                    _carDal.Add(car);
                }
            }
            return new SucccessResult(Messages.Added);
            
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }

        public IDataResult<List<Car>> GetCarsBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

    }
}
