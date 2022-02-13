﻿using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class ProductionLineDal: EfBaseRepository<ProductionLine, EfMSE_DOTNET_Context>, IEfRepository<ProductionLine>
    {
    }
}