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

        public void Add(Car car)
        {
            if(car.DailyPrice>0&& car.Description.Length >= 2)
            {
                carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba özelliklerini hatalı girdiniz.");
            }
           
        }

        public void Delete(Car car)
        {
           carDal.Delete(car);  
        }

        public List<Car> GetAll()
        {
          return carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return carDal.Get(p=>p.Id==id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return carDal.GetAll(p=>p.BrandId== brandId);
        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            return carDal.GetAll(p => p.ColorId==colorId);
        }

        public void Update(Car car)
        {
           carDal.Update(car);
        }
    }
}
