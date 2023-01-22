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
    public class CarManager :ICarService
    {
        ICarDal carDal;
        public CarManager(ICarDal carDal)
        {
           this.carDal = carDal;    
        }

        public List<Car> GetAll()
        {
          return carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return carDal.GetAll(p=>p.BrandId== brandId);
        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            return carDal.GetAll(p => p.ColorId==colorId);
        }
    }
}
