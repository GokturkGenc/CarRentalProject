using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentService
    {
        List<Rent> GetAll();
        Rent GetById(int rentId);
    }
}
