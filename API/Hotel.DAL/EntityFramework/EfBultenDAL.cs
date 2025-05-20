using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAL.Abstract;
using Hotel.DAL.Concrete;
using Hotel.DAL.Repositories;
using Hotel.EntityLayer.Concrete;

namespace Hotel.DAL.EntityFramework
{
    public class EfBultenDAL : GenericRepository<Bulten>, IBultenDAL
    {
        public EfBultenDAL(Context c) : base(c)
        {
        }
    }
}
