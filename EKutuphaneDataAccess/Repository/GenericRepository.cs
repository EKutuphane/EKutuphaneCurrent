using EKutuphaneCore.Entity;
using EKutuphaneDataAccess.Abstract;
using EKutuphaneDataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneDataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly Context _context;
 

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
             _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t) // ekleme INSERT
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t) //güncelleme
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
