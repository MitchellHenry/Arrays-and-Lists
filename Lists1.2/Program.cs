/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 4/04/2019
 * Time: 4:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Lists1._
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
			int count2 = 0;
			int count3 = 0;
			
			int count5 = 0;
			int count6 = 0;
			int count7 = 0;
			int count8 = 0;
			
				count3 = 0;
				
			while(count2 <= 4){
				if(values[count5] == values[0]){
			count3++;
			
			}
					if(values[count5] == values[1]){
			count++;
			
			}
					if(values[count5] == values[2]){
			count6++;
			
			}
					if(values[count5] == values[3]){
			count7++;
			
			}
					if(values[count5] == values[4]){
			count8++;
			
			}
				
				count2++;
				count5++;
				}
				if(count3 == 0){
					count3++;
				}
				Console.WriteLine("The number " + values[0] + " was entered " + count3 + " times!");
				Console.WriteLine("The number " + values[1] + " was entered " + count + " times!");
				Console.WriteLine("The number " + values[2] + " was entered " + count6 + " times!");
				Console.WriteLine("The number " + values[3] + " was entered " + count7 + " times!");
				Console.WriteLine("The number " + values[4] + " was entered " + count8 + " times!");
				
			
			Console.ReadKey(true);
		}
	}
}