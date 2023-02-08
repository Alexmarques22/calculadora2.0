using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora08022023
{
    public class Program
    {



        static void Main(string[] args)
        {
            double valor1 = 0;
            double valor2 = 0;
            double opcao = 0;
            double resposta = 0;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Qual operação você quer fazer? " + "\n");

            Console.WriteLine("1- soma");

            Console.WriteLine("2- subtração");

            Console.WriteLine("3- Divisão");

            Console.WriteLine("4- Multiplicação");

            Console.WriteLine("5- Nada, só estou dando uma olhada." + "\n");

            Console.WriteLine("escolha uma opoção: ");
            opcao = Convert.ToDouble(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine( valor1 + valor2);

            }
            else

            if (opcao == 2)
            {
                Console.WriteLine( valor1 - valor2);
            }
            else

                if (opcao == 3)
            {

                Console.WriteLine(valor1 / valor2);
            }
            if (opcao == 4)
            {
                Console.WriteLine(valor1 * valor2);
            }

            







        }

    }





}
