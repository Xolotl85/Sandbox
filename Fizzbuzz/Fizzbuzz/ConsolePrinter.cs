using System;

namespace Fizzbuzz
{
	public class ConsolePrinter : IPrinter
	{
		public ConsolePrinter()
		{
			
		}
		
		public void Print(string value)
		{
			Console.WriteLine(value);
		}
	}
}
