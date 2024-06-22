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


            Console.Write("Enter Age : ");
            String temp = Console.ReadLine();
            int age = Convert.ToInt32(temp);

            Console.WriteLine(age>18?"You Can Drive":"You Can't Drive");
        }
    }
}