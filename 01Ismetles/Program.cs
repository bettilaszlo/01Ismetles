using System;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" };

        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;

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
            Console.WriteLine("Gép: {0} ----- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);
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

            if (ember == gep) 
            {
                return 0; //Döntetlen
            }
            else if (
                (ember == 0 && gep == 1)
                ||
                (ember == 1 && gep == 2)
                ||
                (ember == 2 && gep == 0)
                    ) 
            {
                gepNyer++;
                return 1; //Gép nyer
            }
            else 
            {
                jatekosNyer++;
                return 2; //Játékos nyer
            }
        }
        private static bool akarjatszani()
        {
            //throw new NotImplementedException();

            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Tovább? [i/n]: ");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n------------------------------------------------------------------------");

            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Statisztikakiiras()
        {
            Console.WriteLine("\t Menetek száma: {0}, Játékos győzelmének száma: {1}, Gép győzelmének száma: {2}", menet, gepNyer,jatekosNyer);
        }
        static void Main(string[] args)
        {

            // Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);
            bool tovabb = true;
            while (tovabb)
            {
                menet++;

                int jatekosvalasz = Jatekosvalasztas();
                int gepvalasz = Gepvalasztas();
                eredmenykiiras(gepvalasz, jatekosvalasz);

                tovabb = akarjatszani();

                Console.WriteLine("");
            }
            Statisztikakiiras();

            //Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            Console.ReadKey();
        }

        
    }
}
