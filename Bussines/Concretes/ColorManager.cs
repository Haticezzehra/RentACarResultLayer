using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ColorManager : IColorService
    {
        IColorDal colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            colorDal.Add(color);
            return new SuccessResult("Renk eklendi");
        }

        public IResult Delete(Color color)
        {
            colorDal.Delete(color);
            return new SuccessResult("Renk silindi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(colorDal.GetAll(), "Renkler listelendi");
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return new SuccessDataResult<Color>(colorDal.Get(c => c.Id == ColorId));
        }

        public IResult Update(Color color)
        {
            colorDal.Update(color);
            return new SuccessResult("Renk güncellendi");
        }
    }
}
