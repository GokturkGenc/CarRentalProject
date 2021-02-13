using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public static IEnumerable<object> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _cardal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _cardal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }
    }
}