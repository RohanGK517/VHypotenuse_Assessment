using ConsoleApp;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI, Rohan G K");
            /*Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Number :" + a);*/

            /*string firstName = "rohan";
            string lastName = "gk";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
            string fullName = (firstName + lastName);  //concatination
            Console.WriteLine(fullName);
            Console.WriteLine(fullName[4]);
            Console.WriteLine(fullName.IndexOf('a'));*/


            /*string text = "Welcome to my arena of BGMI";   //sub string
            Console.WriteLine(text);
            int pos = text.IndexOf("a");
            Console.WriteLine(text.Substring(pos));*/

            //Class1 c = new Class1();
            //c.Demo();

            //Class2 c2 = new Class2();
            //c2.Demo2();

            Class3 c3 = new Class3();
            c3.Demo3();


        }
    }
}
