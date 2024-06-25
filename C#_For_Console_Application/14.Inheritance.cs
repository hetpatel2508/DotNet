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
            Teacher t1 = new Teacher(90,30273,"Het Patel");
            t1.output();
        }
    }
}


/*
Student.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testing
{
    public class Student
    {
        public int id;
        public String name;

        public Student(int i, String n) {
        id = i;
        name = n;
    }
    }
}
*/


/*
Teacher.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testing
{
    public class Teacher:Student
    {
        public int attendance;

        public Teacher(int a, int i, String n):base(i,n)
        {
            attendance = a;
        }
        public void output(){
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Enrollment Number = "+id);
            Console.WriteLine("Attendance = "+attendance);
        }
    }
}
*/