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
    public class ColorManager : IColorService
    {
        IColorDal colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this.colorDal= colorDal;
        }
        public void Add(Color color)
        {
            colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            colorDal.Delete(color); 
        }

        public List<Color> GetAll()
        {
            return colorDal.GetAll();
        }

        public Color GetById(int ColorId)
        {
            return colorDal.Get(c=>c.Id==ColorId);
        }

        public void Update(Color color)
        {
            colorDal.Update(color);
        }
    }
}
