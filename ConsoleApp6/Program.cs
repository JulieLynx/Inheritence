﻿using System;
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
            try
            {
                Human A = new Human("Игорь", "Витальевич", 100);
                Console.WriteLine(A);
                Console.WriteLine("===========================");
                Student B = new Student("Игорь", "Виталевич", 17, 99, "СТУ ПВ 13", 3);
                Console.WriteLine(B);
                Console.WriteLine("===========================");
                Teacher C = new Teacher("Severus", "Sneg", 45, 976, "Potions");
                Console.WriteLine(C);
                Console.WriteLine("===========================");
                Graduate D = new Graduate("Игорь", "Витальевич", 17, 99, "СТУ ПВ 74 ", 3, "Koronavirus","yfghf_hihf67");
                Console.WriteLine(D);
                Console.WriteLine("===========================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
			
		}
	}
}
