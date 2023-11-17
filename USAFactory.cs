using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AudiAbstractFactory
{
	class USAFactory : AudiFactory
	{
		public override Audi CreateModel()
		{
			return new Rs7Audi(); 
		}
	}
}
