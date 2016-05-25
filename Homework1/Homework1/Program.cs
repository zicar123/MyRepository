using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Whatever().DoSomething();
            Console.WriteLine(new Whatever().PickANumber());
            new Whatever().Feature();
        }
    }

    class Whatever
    {
        public void DoSomething()
        {
            Console.WriteLine("Hi");
        }

        public int PickANumber()
        {
            return new Random().Next(1, 100);
        }

        public void Feature()
        {
            this.DoSomething();
        }
    }
}
