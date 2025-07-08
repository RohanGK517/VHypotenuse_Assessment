using System;


namespace ConsoleApp
{
    internal class Class1
    {
        public void Demo()
        {
            int voting = 18;
            int candidate = 35;
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("For the given age voting ability is : " + (age >= voting));   //boolean

            //condition statements
            if (age >= voting && age >= candidate)
            {
                Console.WriteLine("Eligible for voting and as a candidate for election");
            }
            else if (age >= voting)
            {
                Console.WriteLine("Only eligible for voting in the election");
            }

        }

    }
}
