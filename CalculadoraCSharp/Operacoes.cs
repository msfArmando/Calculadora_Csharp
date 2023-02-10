using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp
{
    public class Operacoes
    {
        public Operacoes(string choice)
        {
            Console.WriteLine("Executando....");
        }

        public double Somar(double v1, double v2)
        {
            return v1 + v2;
        }
        public double Subtrair(double v1, double v2)
        {
            return v1 - v2;
        }
        public double Multiplicar(double v1, double v2)
        {
            return v1 * v2;
        }
        public double Dividir(double v1, double v2)
        {
            if(v1 <= 0 || v2 <= 0)
            {
                throw new OperacoesException("Não é possível realizar uma divisão por 0!");
            }
            return v1 / v2;
        }

        public void VerificaOperacao(string choice)
        {
            string[] sinais = { "+", "-", "*", "/", };
            foreach (string s in sinais)
            {
                if (s != choice)
                {
                    throw new OperacoesException("Símbolo da operação inválido!");
                }
                break;
            }
        }
    }
}
