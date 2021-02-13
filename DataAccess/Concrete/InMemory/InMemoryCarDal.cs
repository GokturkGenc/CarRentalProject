using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                    new Car{CarId=1, BrandId=1, ColorId=4, DailyPrice=450,ModelYear=new DateTime (2020), Description ="kaliteli araba" },
                    new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=320,ModelYear=new DateTime (2013), Description ="uygun fiyatlı" },
                    new Car{CarId=3, BrandId=2, ColorId=6, DailyPrice=510,ModelYear=new DateTime (2019), Description ="lüks araba" },
                    new Car{CarId=4, BrandId=3, ColorId=1, DailyPrice=480,ModelYear=new DateTime (2019), Description ="dağ arabası" },
                    new Car{CarId=5, BrandId=2, ColorId=3, DailyPrice=730,ModelYear=new DateTime (2021), Description ="offroad kaliteli" },
                    new Car{CarId=6, BrandId=1, ColorId=2, DailyPrice=550,ModelYear=new DateTime (2019), Description ="alçak spor " },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            //LINQ ile yazdık.

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Update(Car car)
        {
            //LINQ kullandık (yukarıdakinin aynısını aldık birisi silme birisi güncelleme.)
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.CarId = car.CarId;
            carToUpdate.DailyPrice = car.DailyPrice;

        }

        public List<Car> GetAllById(int Id)
        {
            //ICarDal üzerinden listeyi oluşturup buradan implement ettik

            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}