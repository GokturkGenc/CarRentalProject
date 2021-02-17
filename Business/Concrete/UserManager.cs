using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.RentAdded); 
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.RentDelete);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<List<User>> GetAllByEmail(string email)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.Email == email), Messages.UsersListed);
        }

        public IDataResult<List<User>> GetAllByUserName(string firstName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.FirstName == firstName), Messages.UsersListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
