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
			var fizzBuzzResolver = new FizzBuzzResolver();

			//Console.Write("Please Enter Number between 1-100:");
			//string selection = Console.ReadLine();
			//int number = Convert.ToInt32(selection)
			
			for(int number = 1; number <=100; number++){
			fizzBuzzResolver.Resolve(number);
			}
			
			Console.Write("Press any key to continue . . . ");
			
			Console.ReadKey(true);
			}
	}
}