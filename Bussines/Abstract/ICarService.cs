using Entities.Concretes;
using Entities.DTOs;
using Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
        public Car GetById(int id);
        List<CarDetailDto> GetCarDetails();

    }
}
