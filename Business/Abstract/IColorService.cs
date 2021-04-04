using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int id);
        IDataResult<List<Color>> GetAllByColorName(string colorName);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);


    }
}