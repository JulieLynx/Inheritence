using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
                if (value.Length > 0)
                {
                    value.ToLower();
                    last = value;
                }
                //Console.WriteLine(Regex.IsMatch(value, "[^a-z]", RegexOptions.IgnoreCase));
                //Console.ReadKey();
                if (Regex.IsMatch(value, "[^a-zа-я]", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Bad last name");
                }

            }
        }
        public string First
        {
            get => first;
            set
            {
                if (value.Length > 0)
                {
                    value.ToLower();
                    first = value;
                }
                //Console.WriteLine(Regex.IsMatch(value, "[^a-z]", RegexOptions.IgnoreCase));
                //Console.ReadKey();
                if (Regex.IsMatch(value, "[^a-zа-я]", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Bad first name");
                }
            }
        }
        public uint Age
        {
            get => age;
            set
            {
                age = value;
                if (age < 0 || age > 130)
                {
                    throw new Exception("Bad age");
                }
            }
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
            Console.WriteLine("First name: " + First, "\nSecond name: " + Last + "\nAge: " + Age);
        }
        public override string ToString()
        {
            return $"First name:\t{First}\nLast name:\t{Last}\nAge:\t {Age}";
        }
    }
}
