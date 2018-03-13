using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            bmw.Engine();
            Car car = new BMW();
            car.Door();
            bmw.SteerWheel();
            Animal.Eat();
            Tiger.Eat();
            Console.ReadLine();
        }
    }

    public abstract class Car
    {
        public abstract void SteerWheel();
        public void Door()
        {
            Console.WriteLine("This car have four doors");
        } 
    }

    public class BMW : Car
    {
        public void Engine()
        {
            Console.WriteLine("BMW has been producing engines for automobiles, motorcycles and aircraft since 1917");
        }

        public override void SteerWheel()
        {
            Console.WriteLine("BMW Steering Wheel captures the feel and spirit of the racetrack");
        }

        public new void Door()
        {
            Console.WriteLine("I only have two doors");
        }
    }


    class Animal
    {
        public static void Eat()
        {
            Console.WriteLine("I like strawberry!");
        }
    }

    class Tiger : Animal
    {
        public static void Run()
        {
            Console.WriteLine("I can run 65 km//h");
        }

        public new static void Eat()
        {
            Console.WriteLine("I like meat!");
        }
    }
}
