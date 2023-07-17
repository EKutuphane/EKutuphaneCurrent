﻿using EKutuphaneCore.Entity;
using EKutuphaneDataAccess.Concrete;
using EKutuphaneDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneDataAccess.EntityFramework
{
    public class EfManagerDal : GenericRepository<Manager>
    {
        public EfManagerDal(Context context) : base(context)
        {
        }
    }
}
