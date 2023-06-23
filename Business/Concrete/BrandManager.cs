using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _branddal;
        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }
        public List<Brand> GetAll()
        {
            return _branddal.GetAll();
        }
        public List<Brand> GetBrandId(int id)
        {
            return _branddal.GetAll(p=>p.BrandId== id);
        }

        void IBrandService.Add(Brand brand)
        {
            _branddal.Add(brand);
        }

        void IBrandService.Update(Brand brand)
        {
            _branddal.Update(brand);
        }

        void IBrandService.Delete(Brand brand)
        {
            _branddal.Delete(brand);
        }
    }
}
