using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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

    public class EfUserDal : EfEntityRepositoryBase<User, CarListContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarListContext())
            {
                var result = from operationClaim in context.Tbl_OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}