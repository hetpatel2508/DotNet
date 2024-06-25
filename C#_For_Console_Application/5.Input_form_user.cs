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
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Enrollment Number : ");
            string t1= Console.ReadLine();
            int enNumber = Convert.ToInt32(t1);

            Console.WriteLine("Name = "+name);
            // Console.WriteLine("Enrollment Number = "+enNumber);  //or
            Console.WriteLine($"Enrollment Number = {enNumber}");
        }
    }
}