/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 4/04/2019
 * Time: 3:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Lists1
{
	class Program
	{
		public static void Main(string[] args)
		{
	        
			Console.WriteLine("Give me five numbers");
			
			var values = new List<int>();
			
			values.Add(int.Parse(Console.ReadLine()));
			values.Add(int.Parse(Console.ReadLine()));
			values.Add(int.Parse(Console.ReadLine()));
			values.Add(int.Parse(Console.ReadLine()));
			values.Add(int.Parse(Console.ReadLine()));
			
			int count = 0;
			
			Console.WriteLine("Give me one more number");
			
			while(count <= 5){
				if(int.Parse(Console.ReadLine()) == values[count]){
				 
					Console.WriteLine("That number has already been entered!");
					count = 10;
				}
				count++;
			
			}
			
			
			Console.ReadKey(true);
		}
	}
}