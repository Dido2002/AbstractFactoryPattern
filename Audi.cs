using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiAbstractFactory
{
	abstract class Audi
	{
		public abstract string  Brand { get; }
		public abstract string Model { get; }
		public abstract string EngineType { get; }
		public abstract string Color { get; }
		public abstract void Print();
	}
}
