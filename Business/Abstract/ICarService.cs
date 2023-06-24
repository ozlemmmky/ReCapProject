using Core.Utilities.Results;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsBrandId(int id );
        IDataResult<List<Car>> GetCarsColorId(int id);
       IDataResult <List<CarDetailDto>> GetCarDetail();

        IResult Add(Car car);


    }
}
