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
        List<Car> GetAll();
        List<Car> GetCarsBrandId(int id );
        List<Car> GetCarsColorId(int id);
        List<CarDetailDto> GetCarDetail();

        void Add(Car car);


    }
}
