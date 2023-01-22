using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
          List<Brand> GetAll();
        void Add(Brand brand);    
        void Delete(Brand brand);
     void Update(Brand brand);
    }
}
