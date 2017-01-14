using System;

namespace FizzyBuzz
{
	public class Program
	{
		static void Main(string[] args)
		{
			for (Number number = new Number(1); number <= 100; number++)
			{
				if (number.IsMod3() && number.IsMod5())
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (number.IsMod3())
				{
					Console.WriteLine("Fizz");
				}
				else if (number.IsMod5())
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine((int)number);
				}
			}

			Console.Read();
		}
	}
}
