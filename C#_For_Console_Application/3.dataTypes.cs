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
            Data Types in C# 

                byte -->  1 byte
                int  -->  4 byte
                long  -->  8 byte
                
                float  -->  4 byte
                double  -->  8 byte

                char   -->  2 byte 
                string   -->  2 byte per character 

                bool  -->  1 bit
            */
            
             byte  byteType = 29;
             int  intType = 52;
            long  longType = 7984335588;

            float  floatType = 68.99F;
            double  doubleType = 69846464.998;
            // double  doubleType = 69846464.998D;  //or
            
            char  charType = 'H';
            string  stringType = "Patel Het R.";
            
            bool  boolType = true;


            if (boolType)
            {
                Console.WriteLine("byte = "+byteType);
                Console.WriteLine("int = "+intType);
                Console.WriteLine("long = "+longType);
                Console.WriteLine("float = "+floatType);
                Console.WriteLine("double = "+doubleType);
                Console.WriteLine("char = "+charType);
                Console.WriteLine("string = "+stringType);
            }
        }
    }
}