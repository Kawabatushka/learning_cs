using System;
using System.Linq;
using System.Text.RegularExpressions;
using Program.Transport_classes;

namespace Program
{

	public abstract class Transport
	{
		protected string Name { set; get; }
		protected ushort Mass { set; get; }
		protected ushort Year { set; get; }


		protected Transport()
		{
			Name = "Unknown";
			Mass = 0;
			Year = 0;
		}

		protected Transport(string _name, ushort _mass,  ushort _year)
		{
			Name = _name;
			Mass = _mass;
			Year = _year;
			Console.WriteLine("Transport");
		}
		public abstract void GetInfo();

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

	
	
	
	interface IWord
	{
		void GetWord();
	}

	public abstract class Phrase
	{
		public int lenght;
	}

	class Bebebe : Phrase, IWord
	{
		public int a = 101;
		public Hand handLeft = new Hand();

		void IWord.GetWord() { }

		int? Min(in int[] _arr)
		{
			return _arr.Where(i => i % 2 == 0).Min();
		}
		
		public void First()
		{
			Console.Write("ААА\nБББ\n\nДа? ");
			//Console.ReadLine();
			string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
			Regex regex = new Regex(@"туп(\w*)");
			MatchCollection matches = regex.Matches(s);
			if (matches.Count > 0)
			{
				foreach (Match match in matches)
					Console.WriteLine(match.Value);
			}
			else
			{
				Console.WriteLine("Совпадений не найдено");
			}
		}

		public void DoSecondMethod()
		{
			var be = new Bebebe();
			be.Second("a1", "aa2", "aaa3", "aaaa4", "aaaaa5", "aaaaaa6");
		}
		
		public void Second(string s1, string s2, string s3, string s4, string s5, string s6)
		{
			Console.Write("ААА\nБББ\n\nДа? ");
			//Console.ReadLine();
			string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
			Regex regex = new Regex(@"туп(\w*)");
			MatchCollection matches = regex.Matches(s);
			if (matches.Count > 0)
			{
				foreach (Match match in matches)
					Console.WriteLine(match.Value);
			}
			else
			{
				Console.WriteLine("Совпадений не найдено");
			}
		}
		
		public static void Основной()
		{

			int[] arr = { 3, 57, 1, 26, 92, 57, 26, 10, 565, -999, 999 };
			int? min;
			//Array.Copy();
			var selectArr = arr.OrderBy(f => f);
			string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
			var selectedPeople = people.Where(p => p.ToUpper().StartsWith("B")).OrderBy(p => p);
			foreach (var VARIABLE in selectArr)
				Console.WriteLine(VARIABLE);

			Console.Out.GetType();
			Bebebe be = new Bebebe();
			min = be.Min(arr);
			Hand hand = new Hand();
			hand.NameAllFingers();
		}

		public static void Main2()
		{
			Console.WriteLine("The first commit in Secondary Branch\n\n");

			Основной();
			Bebebe? ad = null;
			Nullable<int>[] ass = {};
			Nullable<short> aw = (short)ass.Length;
			int? a = 1001;
			int? b = 2000 - a;
			int c = 3000;
			int? s = null;
			Console.WriteLine($"s={s}");
			var be = new Bebebe();
			be.handLeft.name = "Sam";
			Console.WriteLine($"be.lenght = {be.lenght}");
			be.lenght = 10;
			Console.WriteLine($"be.lenght = {be.lenght}");
			string ha = be.handLeft.name;
			Console.WriteLine($"be.handLeft.name = {be.handLeft.name}");
			Console.WriteLine($"be.a = {be.a}");
			Console.WriteLine($"be.handLeft.name = {be.handLeft.name}");
			Console.WriteLine($"be.a = {be.a}");

			Console.ReadKey();
		}
		
		
	}

}