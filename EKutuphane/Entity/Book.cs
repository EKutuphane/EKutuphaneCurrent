using EKutuphaneCore.Abstract;
using EKutuphaneCore.Constants;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneCore.Entity
{
	public class Book : BaseEntity
	{
		public string BookName { get; set; }
		public ushort PageNumber { get; set; }
		public AuthorInfo AuthorInfo { get; set; }
		public DateTime DateTime { get; set; }
		public bool Status { get; set; }  // kitabýn kiralýk durumu hakkýnda bilgi olusturacak 
		public Member? Member { get; set; }
		public int? MemberId { get; set; }
		public BookCategories Categories { get; set; }

	}
}
