
using Business.Concretes;
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
            CarManager carManager = new CarManager();

            carManager.Add(new Car());
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.Description);
            }

        }
    }
}
