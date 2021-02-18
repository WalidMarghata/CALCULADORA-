using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIME
{
    class Program
    {
        static void Main(string[] args)
        {
            Processar();

            Console.ReadKey();
        }

        private static void Processar()
        {
            int GALO;
            Console.Write("Informe a seu time: ");
            int.TryParse(Console.ReadLine(), out GALO);

            if (GALO >= 13)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ATLETICANO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NAO ATLETICANO");
            }
        }
    }
}