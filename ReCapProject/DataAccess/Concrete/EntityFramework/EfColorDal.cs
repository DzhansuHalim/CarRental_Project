﻿using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalContext>, IColorDal
    {
    }
}
