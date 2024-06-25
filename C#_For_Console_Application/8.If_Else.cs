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


            Console.Write("Enter Your Age : ");
            string temp = Console.ReadLine();
            int age = Convert.ToInt32(temp);

            if(age>18 && age<=70){
                Console.WriteLine("You can drive");
            }
            else if(age>70){
                Console.WriteLine("It is recommanded you not to drive");
            }
            else{
                Console.WriteLine("You can't drive at all");
            }


        }
    }
}