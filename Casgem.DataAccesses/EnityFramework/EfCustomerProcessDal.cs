﻿using Casgem.DataAccesses.Abstract;
using Casgem.DataAccesses.Concrete;
using Casgem.DataAccesses.Repository;
using Casgem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccesses.EnityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CostumerProcess>, ICustomerProcessDAL
    {
        public EfCustomerProcessDal(Context contex) : base(contex)
        {
        }
    }
}
