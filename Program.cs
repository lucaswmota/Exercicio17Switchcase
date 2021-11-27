using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.Write("Insira um numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira outro numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação" +
                            "\n 1 - Soma;" +
                            "\n 2 - Subtração;" +
                            "\n 3 - Divisão;" +
                            "\n 4 - Multiplicação." +
                            "\n");
            int operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    total = n1 + n2;
                    Console.Write("O Resultado da Soma é: " + total);
                    break;
                case 2:
                    total = n1 - n2;
                    Console.Write("O Resultado da Subtração é: " + total);
                    break;
                case 3:
                    total = n1 / n2;
                    Console.Write("O Resultado da Divisão é: " + total);
                    break;
                case 4:
                    total = n1 * n2;
                    Console.Write("O Resultado da Multiplicação é: " + total);
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
