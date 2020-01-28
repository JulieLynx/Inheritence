using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Human
	{
		string last;
		string first;
		uint age;
		public string Last
		{
			get
			{
				return last;
			}
			set
			{
				last = value;
			}
		}
		public string First
		{
			get => first;
			set => first = value;
		}
		public uint Age
		{
			get => age;
			set => age = value;
		}
		public Human(string last, string first, uint age)
		{
			Last = last;
			First = first;
			Age = age;

			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		~Human()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public virtual void info()
		{
			Console.WriteLine("First name: "+ First,"\nSecond name: "+ Last + "\nAge: "+Age);
		}
		public override string ToString()
		{
			return $"First name:\t{First}\n Last name:\t{Last}\nAge:\t {Age}";
		}
	}
}
