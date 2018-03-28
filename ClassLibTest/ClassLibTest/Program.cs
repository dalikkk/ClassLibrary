using System;
using System.Threading;
using Claslib;

namespace ClassLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Counting c = new Counting();
            int a = c.Add(4, 4);
            Console.WriteLine(a);
            Console.WriteLine(c.Mul(4,5));
            Console.WriteLine(new Counting().Add(2,3));
        }
    }
}