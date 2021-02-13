using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rent : IEntity
    {
        public int RentId { get; set; }
        public DateTime RentDate { get; set; }
        public int CustomerId { get; set; }
    }
}