using BusinessLayer.Abstract;
using EKutuphaneCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorInfoManager : IAuthorInfoService
    {
        private readonly AuthorInfo _authorInfo;

        public AuthorInfoManager(AuthorInfo authorInfo)
        {
            _authorInfo = authorInfo;
        }

        public void TDelete(AuthorInfo t)
        {
             
        }

        public List<AuthorInfo> TGetAll()
        {
            throw new NotImplementedException();
        }

        public AuthorInfo TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(AuthorInfo t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AuthorInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
