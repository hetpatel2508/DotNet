// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(69,269));    //return maximum
            Console.WriteLine(Math.Min(69,269));    //return minimum

            Console.WriteLine(Math.Abs(-69));     //return positive value

            Console.WriteLine(Math.Sin(90));     //return sin(90)

            Console.WriteLine(Math.Log(180));     //return Log(180)
            Console.WriteLine(Math.Log10(180));     //return Log10(180)
            
            Console.WriteLine(Math.PI);     //return value of pie
            
            Console.WriteLine(Math.Round(69.58));     //return 70
            
            Console.WriteLine(Math.Sqrt(25));     //return Sqrt(25)
            
            Console.WriteLine(Math.Pow(2,4));     //return 2^4 = 2*2*2*2 = 16
            
        }
    }
}