using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> list = new MyList<int>();
			list.Add(45);
			list.Add(32);
			list.Add(1);
			list.Add(52);
			list.Add2(13);
			list.Print();
			Console.ReadKey();
		}
	}
}
