using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.CarImages
{
    public class CarImage
    {
        public IFormFile files { get; set; }
    }
}
