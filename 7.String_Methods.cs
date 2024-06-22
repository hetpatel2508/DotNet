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
            string name = "Patel Het";

            Console.WriteLine("Name = "+name);
            Console.WriteLine($"Name = {name}");

            Console.WriteLine("Length = "+name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            Console.WriteLine(String.Concat(name," R."));

            Console.WriteLine(name.Substring(6));   //Het
            Console.WriteLine(name.Substring(0,5));   //Patel

            Console.WriteLine(name.IndexOf("Het"));  //6 because H=6
            Console.WriteLine(name.LastIndexOf("Het"));  //6 here in last index if there is multiple het in string then it returns starting index of last het in string

            Console.WriteLine(name.Contains("Het"));  //true beacuse Het is in string

            Console.WriteLine(name.Replace("Het","Urvish"));

            Console.WriteLine(name.Trim());  //will only allow 1  " "(whiteSpace) if there are more than one " " then it will remove extra " ".



            string str = "Hello World, Hello Universe";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.Write(word+"  ");
            }


        }
    }
}