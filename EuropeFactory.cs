using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiAbstractFactory
{
	class EuropeFactory:AudiFactory
	{
		public override Audi CreateModel()
		{
			return new A8Audi();
		}

	}
}
