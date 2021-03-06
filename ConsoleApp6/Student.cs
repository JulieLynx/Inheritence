﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


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
			set
            {
                if (value.Length > 0)
                {
                    value.ToLower();
                    group = value;
                }
                //Console.WriteLine(Regex.IsMatch(value, "[^a-z]", RegexOptions.IgnoreCase));
                //Console.ReadKey();
                if (Regex.IsMatch(value, "[^\\sa-zа-я0-9]", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Bad group name");
                }
            }

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
