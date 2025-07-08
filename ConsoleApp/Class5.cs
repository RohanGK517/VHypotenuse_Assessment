using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //Class, Objects, Constructor
    public class Class5
    {
       public string car = "BMW";
    }

        public class Student
    {
        public string name;
        public int standard = 4;
        public int age;
        public int marks;
        public void teacher()  //object methods
        {
            Console.WriteLine("Class teacher of the student is Rohan");
        }
    }

    //Constructor

    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            Console.WriteLine("This is from the constructor");
            name = "Pooo";
            age = 24;

        }
        public Person(string pname, int page)
        {
            name = pname;
            age = page;
        }
    }
}
