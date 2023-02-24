
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;

using System.Runtime.InteropServices;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ColorTest();



            //  CarTest();
        }

        private static void ColorTest()
        {

            //BrandTest();
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color()
            {
                Id = 5,
                ColorName = "Purple"
            });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            /* colorManager.Delete(new Color()
              {
                  Id = 4,
                  ColorName = "Purple"

              });
              foreach (var color in colorManager.GetAll())
              {
                  Console.WriteLine(color.ColorName);
              }
              */
            colorManager.Update(new Color()
            {
                Id = 4,
                ColorName = "Mor"

            });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand()
            {
                Id = 6,
                BrandName = "Audi"

            });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Delete(new Brand()
            {
                Id = 6,
                BrandName = "Audi"

            });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            brandManager.Update(new Brand()
            {
                Id = 6,
                BrandName = "Audiii"

            });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName + "-" + car.DailyPrice);
            }
            carManager.Add(new Car()
            {
                Id = 3,
                BrandId = 4,
                ColorId = 3,
                DailyPrice = 550,
                Description = "Audi",
                ModelYear = 2022


            });/*
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


            foreach (var car in carManager.GetAll())
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
