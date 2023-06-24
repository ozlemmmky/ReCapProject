using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using DataAcces.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SucccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SucccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetId(int id)
        {
           return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p=>p.CustomerId==id));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SucccessResult(Messages.Updated);
        }
    }
}
