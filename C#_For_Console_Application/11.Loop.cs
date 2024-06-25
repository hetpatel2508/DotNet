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
        static void Main(string[] args)
        {


            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();



            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();



            int k = 0;
            while (k < 5)
            {
                Console.Write(k + "  ");
                k++;
            }
            Console.WriteLine();
            Console.WriteLine();




            int j = 0;
            do
            {
                Console.Write(j + "  ");
                j++;
            } while (j < 5);
            Console.WriteLine();
            Console.WriteLine();




            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break; // Break = Leave this loop forever
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();




            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue; // Continue = Leave this particular iteration of loop
                Console.WriteLine("Odd Number: " + i);
            }

        }
    }
}