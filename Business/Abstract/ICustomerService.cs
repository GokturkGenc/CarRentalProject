using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<List<Customer>> GetAllByCompanyName(string companyName);
        IDataResult<List<Customer>> GetByUserId(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);

    }
}
