/*
 * Created by SharpDevelop.
 * User: Xolotl
 * Date: 10/12/2012
 * Time: 5:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fizzbuzz
{
	class Program
	{
		public static void Main(string[] args)
		{
			var fizzBuzzer = new FizzBuzzer();

			Console.Write("Please Enter Number between 1-100:");
			string selection = Console.ReadLine();
			int number = Convert.ToInt32(selection);
			fizzBuzzer.Resolve(number);
			
			Console.Write("Press any key to continue . . . ");
			
			Console.ReadKey(true);
			}
	}
}