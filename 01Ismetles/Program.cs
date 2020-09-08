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

            int jatekosvalasz;
            Console.WriteLine("kő (0), papír (1), olló (2)");
            Console.Write("Válassz: ");
            jatekosvalasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            Console.ReadKey();
        }
    }
}
