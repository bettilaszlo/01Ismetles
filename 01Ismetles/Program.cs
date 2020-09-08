using System;

namespace _01Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "kő", "papír", "olló" };
            int gepvalasz = vel.Next(0, 3);
            Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

            Console.ReadKey();
        }
    }
}
