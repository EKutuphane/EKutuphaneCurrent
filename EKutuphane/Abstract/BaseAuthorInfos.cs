using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphaneCore.Abstract
{
	public abstract class BaseAuthorInfos
	{
		public string Name { get; set; }
		public string Surname { get; set; }

		public DateTime BirthDate { get; set; }
		public string History { get; set; }

	}
}
