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
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic animal sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myDog.MakeSound(); // Output: Bark
            myCat.MakeSound(); // Output: Meow
        }
    }
}
