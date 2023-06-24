using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branddal.GetAll());
        }
        public IDataResult<List<Brand>> GetBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_branddal.GetAll(p=>p.BrandId== id));
        }

         public IResult Add(Brand brand)
        {
            _branddal.Add(brand);
            return new SucccessResult(Messages.Added);
        }

       public  IResult Update(Brand brand)
        {
            _branddal.Update(brand);
            return new SucccessResult(Messages.Updated);
        }

       public IResult Delete(Brand brand)
        {
            _branddal.Delete(brand);
            return new SucccessResult(Messages.Deleted);
        }
    }
}
