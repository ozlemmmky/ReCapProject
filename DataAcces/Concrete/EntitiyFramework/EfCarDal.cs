﻿using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
       
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarsContext context = new CarsContext())
            { var result = from c in context.Cars
                           join b in context.Brands
                            on c.BrandId equals b.BrandId
                         //   from c in context.Cars
                            join color in context.Colors
                            on c.ColorId equals color.ColorId
                            select new CarDetailDto { Id = c.Id, ColorName = color.ColorName, BrandName = b.BrandName, 
                             Description = c.Description, DailyPrice = c.DailyPrice };

                return result.ToList();

            }
        }

    }
}
