using DataAccess.Abstract;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (RentACarContext context = new RentACarContext())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var addEntity = context.Entry(car);
                addEntity.State = EntityState.Added;

            }
        }

        public void Delete(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(filter).ToList();
            }
        }



        public void Update(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updateEntity = context.Entry(car);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
