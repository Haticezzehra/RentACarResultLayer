using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal carDal;
        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {

                carDal.Add(car);
                return new SuccessResult("Ekleme Baasarili");
            }
            return new ErrorResult("Ekleme Başarısız");

        }

        public IResult Delete(Car car)
        {

            carDal.Delete(car);
            return new SuccessResult("Silme basarili");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(), "Listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(carDal.Get(p => p.Id == id), "Araba getirildi");

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails(), "Araba detayları listelendi.");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(p => p.BrandId == brandId), "Araba getirildi");
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(p => p.ColorId == colorId), "Araba getirildi");

        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new SuccessResult("Araba güncellendi");

        }
    }
}
