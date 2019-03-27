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
    static void Main(string[] args)
    {
        int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
         
        int count = 0;
        int total = 0;
        
        while( count < numbers.Length){
        	total = total + numbers[count];
        	count++;
             
        }
        Console.WriteLine("the Total is " + total);
       
        

        Console.ReadKey(true);
    }
    }
}