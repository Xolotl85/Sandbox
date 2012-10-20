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
	public class FizzBuzzResolverStub 
	{
		public string Resolve(int number)
		{
			return "1";
		}
	}
	public class PrinterStub : IPrinter
	{
		public void Print(string value){
			PrintWasCalled = true;
		}
		
		public bool PrintWasCalled{get; private set;}
			
	}

	public class FizzBuzzer
	{
		private IPrinter _printer;
		
		public FizzBuzzer():this(new ConsolePrinter())
		{
			
		}
		
		public FizzBuzzer(IPrinter printer)
		{
			_printer = printer;
		}
		
		public string Resolve(int value)
		{
			
			if(value%3 == 0 && value%5 == 0){
				Console.WriteLine("FizzBuzz");
				return null;
			}
			if(value%3 == 0){
				Console.WriteLine("Fizz");
				return null;
			}
			if(value%5 == 0){
				Console.WriteLine("Buzz");
				return null;
			}
			Console.WriteLine(value);
			return value.ToString();
			
		}
		
	}
	
	/*public class FizzBuzzResolver : IFizzBuzzResolver
	{
		
		public FizzBuzzResolver()
		{
			
		}
		
    	public string Resolve(int value)
		{
			if(value%3 == 0 && value %5 == 0){
		    return "FizzBuzz";
			}
			if(value%3 == 0){
			return "Fizz";
			}
			if(value%5 == 0){
			return "Buzz";
			}
			

			return value.ToString();
			
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
				Assert.AreEqual("FizzBuzz", result);
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
		
		[TestFixture]
		public class FizzBuzzerTests
		{
			[Test]
			public void PrintTest()
			{
				var printer = new PrinterStub();
				var fizzBuzzResolver = new FizzBuzzResolverStub();
				var sut = new FizzBuzzer(printer);
				
				sut.Run();
				
				Assert.IsTrue(printer.PrintWasCalled);
			}
		}
	}
	*/
}