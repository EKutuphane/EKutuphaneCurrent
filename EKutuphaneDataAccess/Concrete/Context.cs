using EKutuphaneCore.Abstract;
using EKutuphaneCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneDataAccess.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("");
		}

        public DbSet<BaseAuthorInfos> BaseAuthorInfos { get; set; }
        public DbSet<BaseEntity> BaseEntitys{ get; set; }
		public DbSet<BaseInfos> BaseInfos { get; set; }
		public DbSet<AuthorInfo> AuthorInfos { get; set; }
		public DbSet<Book>Books { get; set; }
		public DbSet<Manager> Managers { get; set; }
		public DbSet<Member> Members { get; set; }


    }
	
}
