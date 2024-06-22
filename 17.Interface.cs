// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            myCar.Move(); // Output: Car is moving
        }
    }
}
