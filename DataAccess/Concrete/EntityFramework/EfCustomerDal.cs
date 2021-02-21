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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarListContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarListContext context = new CarListContext())
            {
                var result = from cust in context.Tbl_Customers
                         join user in context.Tbl_Users
                         on cust.UserId equals user.UserId
                         select new CustomerDetailDto
                         {
                             UserId = user.UserId,
                             FirstName = user.FirstName,
                             CustomerId = cust.CustomerId,
                         };
                         return result.ToList();
            }
        }
    }
}
