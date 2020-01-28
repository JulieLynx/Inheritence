using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Human A = new Human("Игорь","Витальевич",17);
			Console.WriteLine(A);
			Console.WriteLine("===========================");
			Student B = new Student("Игорь", "Витальевич", 17, 99, "ІЕП-64", 3);
			Console.WriteLine(B);
			Console.WriteLine("===========================");
			Teacher C = new Teacher("Severus", "Sneg", 45, 976,"Potions" );
			Console.WriteLine(C);
			Console.WriteLine("===========================");
			Graduate D = new Graduate("Игорь", "Витальевич", 17, 99, "ІЕП-64", 3,"Koronavirus");
			Console.WriteLine(D);
			Console.WriteLine("===========================");
		}
	}
}
