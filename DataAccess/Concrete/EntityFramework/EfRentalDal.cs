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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarListContext>, IRentalDal
    {
        public List<RentDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
                using (CarListContext context = new CarListContext())
                {
                    var result = from rent in filter == null ? context.Tbl_Rents : context.Tbl_Rents.Where(filter)
                                 join car in context.Tbl_Cars
                                 on rent.CarId equals car.CarId
                                 join cust in context.Tbl_Customers
                                 on rent.CustomerId equals cust.CustomerId
                                 join b in context.Tbl_Brands
                                 on car.BrandId equals b.BrandId
                                 join u in context.Tbl_Users
                                 on cust.UserId equals u.UserId
                                 select new RentDetailDto
                                 {
                                     RentalId = rent.RentalId,
                                     CustomerName = cust.CompanyName,
                                     UserName = u.FirstName + " " + u.LastName,
                                     RentDate = rent.RentDate,
                                     ReturnDate = rent.ReturnDate
                                 };
                    return result.ToList();
                }
        }
        
    
    }
}
