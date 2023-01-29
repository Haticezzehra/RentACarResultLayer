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
        public List<Brand> GetAll();
        public void Add(Brand brand);
        public void Update(Brand brand);
        public void Delete(Brand brand);
        public Brand GetById(int BrandId);

    }
}
