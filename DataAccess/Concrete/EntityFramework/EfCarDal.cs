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
                //var result = from c in context.Tbl_Cars
                //             join b in context.Tbl_Brands
                //             on c.BrandId equals b.BrandId                          
                //             select new CarDetailDto
                //             {
                //                 Id = c.Id,
                //                 BrandName = b.BrandName,
                                 
                //             };
                var result = from car in context.Tbl_Cars
                             join b in context.Tbl_Brands
                             on car.BrandId equals b.BrandId
                             join c in context.Tbl_Colors
                             on car.ColorId equals c.ColorId
                             select new CarDetailDto
                             {

                                 CarId = car.CarId,
                                 Description = car.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}