using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string ColorName  { get; set; }
        public string BrandName { get; set; }
        public short UnitsInGarage { get; set; } //garajda bulunan bu özelliklerdeki araba sayısı.


    }
}
