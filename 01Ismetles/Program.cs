using System;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" };
        static int Jatekosvalasztas()
        {
            Console.WriteLine("kő (0), papír (1), olló (2)");
            Console.Write("Válassz: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Gepvalasztas()
        {
            Random vel = new Random();
            return vel.Next(0, 3);
        }
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
            
            // Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

            int jatekosvalasz = Jatekosvalasztas();
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            int gepvalasz = Gepvalasztas();

            eredmenykiiras(gepvalasz, jatekosvalasz);

            Console.ReadKey();
        }
    }
}
