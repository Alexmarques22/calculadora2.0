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
            double resposta = 0;

            string contador = "";
            while (contador != "parar")
            {

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
            
           

              

                switch (Console.ReadLine())
                {
                    case "1":


                        Console.WriteLine(valor1 + valor2);
                        break;

                    case "2":


                        Console.WriteLine(valor1 - valor2);

                        break;

                    case "3":


                        if (valor1 >= valor2)
                            Console.WriteLine(valor1 / valor2);
                        else
                            Console.WriteLine("operação invalida");
                        break;

                    case "4":

                        Console.WriteLine(valor1 * valor2);

                        break;

                    case "5":

                        break;
                }

                Console.WriteLine("quer continuar? ");
                contador = Console.ReadLine();


            }
            Console.ReadKey();


            



        }

    }





}
