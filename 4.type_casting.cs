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
            /*
            Type Casting has 2 types

            1.) Implicit Casting 

                char -> int -> long -> float -> double
                    <!=    <!=     <!=      <!=                                                

            2.) Explicit Casting

                int x = (int)3.5;
                
            */

            
            //Implicit Casting
            char c ='6';
            int n = c;

            long l = 68;
            double d = l+1.59;

            Console.WriteLine(n); //ascii value of 6 = 54 will be printed
            Console.WriteLine(d); 
            Console.WriteLine(); 
            


            //Explicit Casting
            
            
            int t1 = Convert.ToInt32(d);    //accurate because 69.59 = 70 
            int t2 = (int)d;  //not accurate because 69.59 = 70 in int but it shows 69

            Console.WriteLine(t1); 
            Console.WriteLine(t2); 
        }
    }
}