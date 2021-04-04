using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarListContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (CarListContext context = new CarListContext())
            {
                return context.CarImages.Any(p => p.ImageId == id);
            }
        }

    }
}