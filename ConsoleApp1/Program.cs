using System;
using Program.Transport_classes;

namespace Program
{

	public abstract class Transport
	{
		public string Name { set; get; }
		public ushort Mass { set; get; }
		public virtual ushort Year { set; get; }


		protected Transport()
		{
			Name = "Unknown";
			Mass = 0;
			Year = 0;
		}

		public Transport(string _name, ushort _mass,  ushort _year)
		{
			Name = _name;
			Mass = _mass;
			Year = _year;
			Console.WriteLine("Transport");
		}
		public abstract void GetInfo();
		
	}

	public class Program
	{
		static void Main()
		{ 
			Transport t = new Car("Audi", 1290, 2014, 19);
			Car c = new Car("Mercedes-Benz", 1350, 2008, 15);
			Cargo crg = new Cargo("Volvo", 8000, 2017, 28, 15000);
			Car c2 = new Car();
			Cargo crg2=(Cargo)c2;
			t.GetInfo();
			c.GetInfo();
			crg.GetInfo();
			c2.GetInfo();
			Console.WriteLine(crg.ToString());
			Console.ReadKey();
		}
	}
	
}