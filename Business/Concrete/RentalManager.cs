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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if(rental.ReturnDate==null)  
            {
                _rentalDal.Add(rental);
                return new SucccessResult(Messages.Added);
            }
            return new ErrorResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SucccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll()); 
        }

        public IDataResult<List<Rental>> GetId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p=>p.RentalId==id));
        }

        public IResult Update(Rental rental)
        {
           _rentalDal.Update(rental);
            return new SucccessResult(Messages.Updated);
        }
    }
}
