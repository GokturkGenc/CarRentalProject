using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        // IResult Add(User user);
        //IResult Update(User user);
        //IResult Delete(User user);

        //List<OperationClaim> GetClaims(User user);
        //User GetByMail(string email);

        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

    }

}
