using EKutuphaneCore.Abstract;
using EKutuphaneDataAccess.Concrete;
using EKutuphaneDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneDataAccess.EntityFramework
{
    public class EfBaseInfosDal : GenericRepository<BaseInfos>
    {
        public EfBaseInfosDal(Context context) : base(context)
        {
        }
    }
}
