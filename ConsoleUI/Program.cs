
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Drawing;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach(var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName + "-" + car.DailyPrice);
            }
           /* carManager.Add(new Car()
            {
                Id = 2,
                BrandId = 4,
                ColorId = 3,
                DailyPrice = 550,
                Description = "Audi",
                ModelYear = 2022


            });
            carManager.Delete(new Car()
             {
                 Id = 2,
                 BrandId = 4,
                 ColorId = 3,
                 DailyPrice = 550,
                 Description = "Audi",
                 ModelYear = 2022


             });
           
            carManager.Update(new Car()
            {
                Id = 2,
                BrandId = 4,
                ColorId = 3,
                DailyPrice = 550,
                Description = "Mercedes",
                ModelYear = 2022


            });
           */
         
           

        
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("********************************************");
            //Marka Idsine göre arabaları getirme
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("********************************************");
            //Color Idsine göre arabaları getirme
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("********************************************");
            //Id ye göre araba getirme
            Console.WriteLine(carManager.GetById(1).Description);
        }
    }
}
