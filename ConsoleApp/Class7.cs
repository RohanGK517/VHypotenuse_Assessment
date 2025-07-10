using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Polymorphism and Interface
    public class Human   
    {
        public virtual void job()
        {
            Console.WriteLine("Human does their work");
        }
        public void salary()
        {
            Console.WriteLine("Only the teachers or trainers get the salary");
        }
    }
    public class Students : Human
    {
        public override void job()
        {
            Console.WriteLine("Students have learn the concepts");
        }
    }

    public class Teacher : Human
    {
        public override void job()
        {
            Console.WriteLine("Teacher train the students");
        }
    }

    //Interface and Multiple Interface 

    public interface IEat
    {
        void digest();
    }
    public interface IRun
    {
        void run();
    }
    public class Activity : IEat, IRun
    {
        public void run()
        {
            Console.WriteLine("Running is good for health");
        }
        public void digest()
        {
            Console.WriteLine("Eating food");
        }
    }
}
