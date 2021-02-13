using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentManager
    {
        IRentDal _rentdal;

        public RentManager(IRentDal rentdal)
        {
            _rentdal = rentdal;
        }

        public List<Rent> GetAll()
        {
            return _rentdal.GetAll();
        }

        //public List<Rent> GetAllByBrandId(int id)
        //{
        //    return _rentdal.GetAll(p => p.BrandId == id);
        //}

        //public List<Rent> GetAllByColorId(int id)
        //{
        //    return _rentdal.GetAll(p => p.ColorId == id);
        //}
    }
}
