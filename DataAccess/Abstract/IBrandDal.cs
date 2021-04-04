using Entities.Concrete;
using System;
using Core.DataAccess;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
    }
}