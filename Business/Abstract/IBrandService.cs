﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int id);
        IDataResult<List<Brand>> GetAllByBrandName(string brandName);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);


    }
}