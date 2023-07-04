using EKutuphaneCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneCore.Entity
{
	public class Member : BaseInfos
	{
		public string UserName { get; set; }
		public int Phone { get; set; }
		public int Address { get; set; }
		public DateTime Birtdate { get; set; }
		public IList<Book>? Books { get; set; }
		public int? BookId { get; set; }

	}
}
