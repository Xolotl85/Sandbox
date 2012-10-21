/*
 * Created by SharpDevelop.
 * User: Xolotl
 * Date: 10/12/2012
 * Time: 7:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fizzbuzz
{
	
    public class FizzBuzzResolver
	{
		private IPrinter _printer;
		
		public FizzBuzzResolver():this(new ConsolePrinter())
		{
			
		}
		
		public FizzBuzzResolver(IPrinter printer)
		{
			_printer = printer;
		}
		
		public string Run()
		{
    		return "1";
		}
		
		public string Resolve(int value)
		{
			
			if(value%3 == 0 && value%5 == 0){
				Console.WriteLine("FizzBuzz");
				return "Fizzbuzz";
			}
			if(value%3 == 0){
				Console.WriteLine("Fizz");
				return "Fizz";
			}
			if(value%5 == 0){
				Console.WriteLine("Buzz");
				return "Buzz";
			}
			Console.WriteLine(value);
			return value.ToString();
			
		}
		
    }
		[TestFixture]
		public class FizzBuzzResolverTest
		{
			[Test]
			public void FizzTest()
			{
				var sut = new FizzBuzzResolver();
				var result = sut.Resolve(3);
				Assert.AreEqual("Fizz", result);
				
			}
		
			[Test]
			public void BuzzTest()
			{
				var sut = new FizzBuzzResolver();
				var result = sut.Resolve(5);
				Assert.AreEqual("Buzz", result);
			}
			[Test]
			public void FizzBuzzTest()
			{
				var sut = new FizzBuzzResolver();
				var result = sut.Resolve(15);
				Assert.AreEqual(result, "FizzBuzz");
			}
		
			[Test]
			public void NumbersNotDivisibleBy3Or5()
			{
				var number = 11;
				var sut = new FizzBuzzResolver();
				var result = sut.Resolve(number);
				Assert.AreEqual(number.ToString(), result);
			}
		}	
}