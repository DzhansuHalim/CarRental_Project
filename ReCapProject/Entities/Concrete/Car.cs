﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; } 
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; } 
        public double DailyPrice { get; set; }
        public string DescriptionCar { get; set; }
    }
}
