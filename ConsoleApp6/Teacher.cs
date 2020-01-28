using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Teacher : Human
	{
		int exp;
		string subject;
		public int Exp
		{
			get => exp;
			set => exp = value;
		}
		public string Subject
		{
			get => subject;
			set => subject = value;
		}
		
		public Teacher(string last, string first, uint age,int exp, string subject): base (last, first, age)
		{
			Exp = exp;
			Subject = subject;

			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		~Teacher()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public void info()
		{
			base.info();
			Console.WriteLine("Exp:\t: " + Exp, "\nSubject:\t" + Subject);
			//First name: " + First, "\nSecond name: " + Last + "\nAge: " + Age + "\n
		}
		public override string ToString()
		{
			return $"Exp:\t{Exp}\nSubject:\t{Subject}";
			//First name:\t{First}\n Last name:\t{Last}\nAge:\t {Age}\n
		}
	}
}
