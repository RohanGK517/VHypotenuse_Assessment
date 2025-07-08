using System;
using System.Net;


namespace ConsoleApp
{
    public class Class4  
    {

        //Methods and it's concepts
        public void Method1()
            {
                Console.WriteLine("It is the 1st method example");
            }

        public static int Method2(int a, int b)
        {
            return a + b; 
        }

        public double Salary(double basicPay, int workingDays, double allowance = 1000, double bonus = 0)
        {
            return (basicPay / 30 * workingDays) + allowance + bonus; 
        }

        public double Salary(double basicPay, int workingDays)
        {
            return basicPay / 30 * workingDays;
        }


    }
}

