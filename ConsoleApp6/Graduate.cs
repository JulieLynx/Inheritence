using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Graduate:Student
	{
		string diploma_theme;
		public string Diploma_theme
		{
			get
			{
				return diploma_theme;
			}
			set
			{
				diploma_theme = value;
			}
		}
		
		public Graduate(string last, string first, uint age, int rating, string group, int course,string diploma_theme): base(last, first, age, rating, group, course)
		{
			Diploma_theme = diploma_theme;

			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		~Graduate()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public virtual void info()
		{
			Console.WriteLine($"Diploma theme:\n{Diploma_theme}");
		}
		public override string ToString()
		{
			return $"First name:\t{ First}\nLast name:\t{ Last}\nAge:\t{ Age}\nRating:\t{ Rating}\nGroup:\t{ Group}\nCourse:\t{ Course}\nDiploma theme:\t{Diploma_theme}";
		}
	}
}
