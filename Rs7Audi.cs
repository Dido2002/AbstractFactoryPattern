using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiAbstractFactory
{
	class Rs7Audi: Audi
	{	
		public override string Brand 
		{
			get { return "Audi Rs7"; }
		}
		public override string Model
		{
			get { return "Rs7"; }
		}
		public override string EngineType
		{
			get { return "Benzin"; }
		}
		public override string Color
		{
			get { return "Grey"; }
		}

		public override void Print()
		{
			Console.WriteLine($"The brand of the car is: {Brand}");
			Console.WriteLine($"The model of the car is: {Model}");
			Console.WriteLine($"The engine type of the car is: {EngineType}");
			Console.WriteLine($"The color of the car is: {Color}");
		}
	}
}
