using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class3
    {
        public void Demo3()
        {
            string[] arr = new string[3];
            arr[0] = "Ninja H2R";
            arr[1] = "BMW M1000RR";
            arr[2] = "Triumph 400";
            Console.WriteLine(arr[2]);


            string[] arr2 = { "G-Wagon", "Porsche", "Defender", "Mini Cooper" };
            Array.Sort(arr2);                               //Sorted Array
            Console.WriteLine(string.Join(",", arr2));    //method to print whole array
            arr2[1] = "McLaren";
            Console.WriteLine(string.Join(",", arr2)); 

            int[] arr3 = { 1,2,3,4 };
            for (int i = 0; i <= arr3.Length; i++)    //looping through array
            Console.WriteLine(i); 
            Console.WriteLine("Maximum number :" + arr3.Max());
            Console.WriteLine("Minimum number :" +arr3.Min());
            Console.WriteLine("Sum of the numbers :" +arr3.Sum());


            //Multidimensional Array

            int[,] arr4 = { {1, 2, 3,}, {2, 3, 4}, {3, 4, 5} };
            Console.WriteLine("Access multidimension array val :" +arr4[1, 2]);
            foreach(int i in arr4)              //Looping in multidimensional array
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Value of multidimension array before change :" + arr4[0, 2]);
            arr4[0, 2] = 9;               //Changing value in multidimension array
            Console.WriteLine("Changed value in multidimension array :" +arr4[0, 2]);

        }
    }
}
