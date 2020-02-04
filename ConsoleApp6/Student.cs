using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Student : Human
	{
		int rating;
		string group;
		int course;
		public int Rating
		{
			get => rating;
			set => rating = value;

		}
		public string Group
		{
			get => group;
			set => group = value;
		}
		public int Course
		{
			get => course;
			set => course = value;
		}
		public Student(string last, string first, uint age, int rating, string group, int course): base(last, first,age)
		{
			Rating = rating;
			Group = group;
			Course = course;

			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		~Student()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public void info()
		{
			base.info();
			Console.WriteLine( "\nRaiting:\t" + Rating + "\nGroup:\t" + Group + "\nCourse:\t" + Course);
		}
		public override string ToString()
		{
			return base.ToString()+$"\nRating:\t{Rating}\nGroup:\t{Group}\nCourse:\t{Course}";
			
		}
	}
}
