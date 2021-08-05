using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        //CarName, BrandName, ColorName, DailyPrice.
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }


    }
}
