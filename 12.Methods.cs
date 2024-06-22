// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        public static void output(string name)
        {
            Console.WriteLine("Welcome, " + name);
        }

        static float average(int a, int b)
        {
            return (float)(a + b) / 2;
        }

        public static float average(int a, int b, int c)
        {
            return (float)(a + b + c) / 3;
        }

        static void Main(string[] args)
        {
            output("Het");
            Console.WriteLine("Average(5, 4) = " + average(5, 4));
            Console.WriteLine("Average(1, 2, 3) = " + average(1, 2, 3));
        }
    }
}
