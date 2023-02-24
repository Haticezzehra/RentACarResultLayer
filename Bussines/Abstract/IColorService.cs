using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        public IDataResult<List<Color>> GetAll();
        public IResult Add(Color color);
        public IResult Update(Color color);
        public IResult Delete(Color color);
        public IDataResult<Color> GetById(int ColorId);
    }
}
