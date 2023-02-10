using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            double v1 = 0;
            double v2 = 0;
            double res = 0;

            while (ciclo)
            {
                Console.WriteLine("CALCULADORA\n-----------\n+ = ADIÇÃO\n- = SUBTRAÇÃO\n* = MULTIPLICAÇÃO\n/ = DIVISÃO\n-----------");
                Console.WriteLine("DIGITE A OPERAÇÃO ESCOLHIDA ABAIXO ou X para fechar: ");
                try
                {
                    string choice = Console.ReadLine().ToLower();
                    var operacao = new Operacoes(choice);
                    operacao.VerificaOperacao(choice);

                    if (choice == "x")
                    {
                        Console.WriteLine("Fechando aplicação...");
                        break;
                    }

                    Console.WriteLine("Digite o primeiro valor: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    v2 = double.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case "+":

                            res = operacao.Somar(v1, v2);

                            break;
                        case "-":

                            res = operacao.Subtrair(v1, v2);

                            break;
                        case "*":

                            res = operacao.Multiplicar(v1, v2);

                            break;
                        case "/":

                            res = operacao.Dividir(v1, v2);
                            break;
                        default:
                            throw new OperacoesException("Símbolo da operação inválido!");
                    }

                    Console.WriteLine($"{v1} {choice} {v2} = {res}");
                }
                catch (OperacoesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(Console.ReadLine());
        }
    }
}
