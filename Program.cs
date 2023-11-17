using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace AudiAbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.ReadKey();	

			AudiFactory myAudi = new EuropeFactory();
			var audiA8 = myAudi.CreateModel();
			audiA8.Print();
		
			myAudi = new USAFactory();
			var audiRs7 = myAudi.CreateModel();
			audiRs7.Print();

			
		}
	}
}
