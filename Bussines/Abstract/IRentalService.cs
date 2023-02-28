using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        public IDataResult<List<Rental>> GetAll();
        public IResult Add(Rental rental);
        public IResult Update(Rental rental);
        public IResult Delete(Rental rental);
        public IDataResult<Rental> GetById(int RentalId);
    }
}
