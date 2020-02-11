using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp6
{
	class Graduate:Student
	{
		string diploma_theme;
        string mail;
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
        public string Mail
		{
			get
			{
				return mail;
				
			}
			set
            {
                if (value.Length > 0)
                {
                    value.ToLower();
                    mail = value;
                }
                //Console.WriteLine(Regex.IsMatch(value, "[^a-z]", RegexOptions.IgnoreCase));
                //Console.ReadKey();
                if (Regex.IsMatch(value, "[^_a-zа-я0-9],[^@.org]", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Bad last name");
                }

            }
        }
		
		public Graduate(string last, string first, uint age, int rating, string group, int course,string diploma_theme,string mail): base(last, first, age, rating, group, course)
		{
			Diploma_theme = diploma_theme;
            Mail = mail;
			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		~Graduate()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public virtual void info()
		{
			Console.WriteLine($"\nDiploma theme:\t{Diploma_theme}\nMail:\t{Mail}");
		}
		public override string ToString()
		{
			return base.ToString()+$"\nDiploma theme:\t{Diploma_theme},\nMail:\t{Mail}";
		}
	}
}
