using ConsoleApp;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI, Rohan G K");
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Number :" + a);

            string firstName = "rohan";
            string lastName = "gk";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
            string fullName = (firstName + lastName);  //concatination
            Console.WriteLine(fullName);
            Console.WriteLine(fullName[4]);
            Console.WriteLine(fullName.IndexOf('a'));


            string text = "Welcome to my arena of BGMI";   //sub string
            Console.WriteLine(text);
            int pos = text.IndexOf("a");
            Console.WriteLine(text.Substring(pos));

            Class1 c = new Class1();
            c.Demo();

            Class2 c2 = new Class2();
            c2.Demo2();

            Class3 c3 = new Class3();
            c3.Demo3();

            Class4 c4 = new Class4(); 
            c4.Method1();

            int res = Class4.Method2(4, 9);        //If the method is static we've to use Class name directly to access
            Console.WriteLine(res);

            double Emp1 = c4.Salary(basicPay: 30000, workingDays: 30);
            Console.WriteLine("Salary of Emp1 (used default parameters) is Rs." + Emp1);
            double Emp2 = c4.Salary(40000,30,2000,1600);
            Console.WriteLine("Salary of Emp1 (gave all parameters) is Rs." + Emp2);
            double Emp3 = c4.Salary(20000,25);
            Console.WriteLine("Salary of Emp1 (overloaded method) is Rs." + Emp3);

            Class5 c5 = new Class5();
            Console.WriteLine(c5.car);

            //Multiple objects and object methods

            Student s = new Student();
            s.name = "Kantha";
            s.age = 10;
            Console.WriteLine(s.name);
            Console.WriteLine(s.age);
            Console.WriteLine(s.standard);
            Console.WriteLine("Enter the marks");
            s.marks = Convert.ToInt32(Console.ReadLine());
            if (s.marks > 35)
            {
                Console.WriteLine(s.name + "is Pass");
            }
            else
            {
                Console.WriteLine(s.name + "is Fail");

            }
            s.teacher();

            Student s1 = new Student();
            s1.name = "Liki";
            s1.age = 10;
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.age);
            Console.WriteLine(s1.standard);
            Console.WriteLine("Enter the marks");
            s1.marks = Convert.ToInt32(Console.ReadLine());
            if (s1.marks > 35)
            {
                Console.WriteLine(s1.name + " is Pass");
            }
            else
            {
                Console.WriteLine(s1.name + " is Fail");

            }
            s1.teacher();

            //Constructor's object

            Person p = new Person();
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);

            Person p1 = new Person("Manu", 25);
            Console.WriteLine(p1.name + "'s age is " + p1.age);


        }
    }
}
