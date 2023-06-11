using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Program
{
	
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

		public static void Main()
		{
			Console.WriteLine("The second commit\n\n");
		
			int a = 1001;
			int b = 2000 - a;

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