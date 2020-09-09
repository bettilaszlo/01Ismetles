using System;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" };
        static void eredmenykiiras( int gep, int ember)
        {
            Console.WriteLine("Gép: {0} ---Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);
            switch (Embernyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen");
                    break;

                case 1:
                    Console.WriteLine("Gép nyert");
                    break;

                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;
            }
        }
        static int Embernyer(int gep, int ember)
        {

            if (ember == gep) //Döntetlen
            {
                return 0;
            }
            else if (
                (ember == 0 && gep == 1)
                ||
                (ember == 1 && gep == 2)
                ||
                (ember == 2 && gep == 0)
                    ) //Gép nyer
            {
                return 1;
            }
            else //Játékos nyer
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            Random vel = new Random();
           
            int gepvalasz = vel.Next(0, 3);
            // Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

            int jatekosvalasz;
            Console.WriteLine("kő (0), papír (1), olló (2)");
            Console.Write("Válassz: ");
            jatekosvalasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            

            eredmenykiiras(gepvalasz, jatekosvalasz);

            Console.ReadKey();
        }
    }
}
