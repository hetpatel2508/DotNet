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
            Rectangle r1 = new Rectangle(55,65);
            
            // r1.setLength(69);
            // r1.setBreadth(75);

            Console.WriteLine("Lenght = "+r1.getLenght());
            Console.WriteLine("Breadth = "+r1.getBreadth());

        }
    }
}


/*
In Rectangle.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testing
{
    public class Rectangle
    {
        private int length;
        private int breadth;

        public Rectangle(){
            this.length=69;
            this.breadth=75;
        }
        public Rectangle(int len,int bre){
            this.length = len;
            this.breadth = bre;
        }

        public void setLength(int len){
            length=len;
        }
        public void setBreadth(int bre){
            breadth=bre;
        }
        public int getLenght(){
            return length;
        }
        public int getBreadth(){
            return breadth;
        }
        ~Rectangle()
        {
            Console.WriteLine("Object is removed");
        }
    }
}
*/