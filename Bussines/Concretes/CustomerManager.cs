using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            customerDal.Add(customer);
            return new SuccessResult("Müşteri başarılı bir şekilde eklendi");
        }

        public IResult Delete(Customer customer)
        {
            customerDal.Delete(customer);
            return new SuccessResult("Müşteri silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int CustomerId)
        {
            return new SuccessDataResult<Customer>(customerDal.Get(c => c.Id == CustomerId));      
        }

        public IResult Update(Customer customer)
        {
           customerDal.Update(customer);
            return new SuccessResult("Müşteri güncellendi.");
        }
    }
}
