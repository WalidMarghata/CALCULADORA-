using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WALID CALCULADORA 
{
    class Program
    {
        static void Main(string[] args)
        {

            double Num1, Num2, Resultado = 0;
            char Operacao;

            Console.WriteLine("Entre com a operação-->");
            Console.WriteLine("+ Adição-------------->");
            Console.WriteLine("- Subtração----------->");
            Console.WriteLine("* Multiplicação------->");
            Console.WriteLine("/ Divisão------------->");
            Console.WriteLine("-----------------------");

            Console.WriteLine();

            Console.Write("Operação: ");

            char.TryParse(Console.ReadLine(), out Operacao);

            Console.WriteLine();
            Console.Write("Informe o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out Num1);

            Console.WriteLine();
            Console.Write("Informe o segundo valor: ");
            double.TryParse(Console.ReadLine(), out Num2);

            Console.WriteLine();
            Console.WriteLine();

            switch (Operacao)
            {
                case '+':
                    Resultado = Adicao(Num1, Num2);
                    break;

                case '-':
                    Resultado = Subtracao(Num1, Num2);
                    break;

                case '*':
                    Resultado = Multiplicacao(Num1, Num2);
                    break;

                case '/':
                    Resultado = Divisao(Num1, Num2);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Resultado: {0}", Resultado));

            Console.ReadKey();
        }

        private static Double Adicao(double Num1, double Num2)
        {
            return (Num1 + Num2);
        }

        private static Double Subtracao(double Num1, double Num2)
        {
            return (Num1 - Num2);
        }

        private static Double Multiplicacao(double Num1, double Num2)
        {
            return (Num1 * Num2);
        }

        private static Double Divisao(double Num1, double Num2)
        {
            return (Num1 / Num2);
        }
    }
}