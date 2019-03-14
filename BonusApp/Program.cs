using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    class Program
    {
		public delegate int AnonymeLambdaDelegates(int x);
		public delegate int AnonymeLambdaDelegates2Parameters(int x, int y);
		static void Main(string[] args)
        {
			AnonymeLambdaDelegates2Parameters d = (x, y) => { return x + y; };

			Console.WriteLine("das ist der mit 2 argumenten: " + d(5,5));

			AnonymeLambdaDelegates d1 = x => x * 10;

			Console.WriteLine("das ist der eine der mal 10 macht: " + d1(5));

			d1 = x => x * x;

			Console.WriteLine("das ist der eine der normal mal macht: " + d1(5));

			Console.ReadKey();

		}
    }
}
