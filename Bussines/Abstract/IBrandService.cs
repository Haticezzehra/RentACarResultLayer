using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public IDataResult<List<Brand>> GetAll();
        public IResult Add(Brand brand);
        public IResult Update(Brand brand);
        public IResult Delete(Brand brand);
        public IResult GetById(int BrandId);

    }
}
