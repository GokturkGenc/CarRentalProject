using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rent, CarListContext>, IRentDal
    {

    }
}