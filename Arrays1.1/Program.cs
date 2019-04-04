/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 11:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arrays1._
{
	class Program
	{
		public static void Main(string[] args)
		{
			int count = 0;
			string[] names = new string[5];
			
			while(count < names.Length) {
			     string name = Console.ReadLine();
				names[count] = name;
				count++;
			}
			count = 0;
			while(count < names.Length){
				Console.WriteLine("Hello " + names[count]);
				count++;
			}
			Console.ReadKey(true);
		}
	}
}