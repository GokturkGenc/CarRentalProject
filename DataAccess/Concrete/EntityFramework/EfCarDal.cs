using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarListContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarListContext context = new CarListContext())
            {
                var result = from c in context.Tbl_Cars
                             join b in context.Tbl_Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName
                             };
                return result.ToList();
            }
        }
    }
}