using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;

        void BranManager(IBrandDal brandDal)
        {
            this.brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int BrandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
