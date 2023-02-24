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
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            this.brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            brandDal.Add(brand);
            return new SuccessResult("Marka eklendi");
        }

        public IResult Delete(Brand brand)
        {
            brandDal.Delete(brand);
            return new SuccessResult("Marka silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(brandDal.GetAll(), "Markalar Listelendi");
        }

        public IDataResult<Brand> GetById(int BrandId)
        {
            return new SuccessDataResult<Brand>(brandDal.Get(b => b.Id == BrandId), "Marka getirildi");

        }

        public IResult Update(Brand brand)
        {
            brandDal.Update(brand);
            return new SuccessResult("Marka guncellendi");
        }

      
    }
}
