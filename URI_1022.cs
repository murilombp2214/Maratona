using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class URI
    {
        //1022
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            while (quantidade-- > 0)
            {
                string formula = Console.ReadLine();
                var (numerador, denominador) = ProcessFormula(formula);
                string divisaoSimplificada = SimplificarOperacao(numerador, denominador);
                ExibirFormula(numerador, denominador, divisaoSimplificada);
            }
        }

        private static void ExibirFormula(int numerador, int denominador, string divisaoSimplificada)
        {
            Console.WriteLine($"{numerador}/{denominador} = {divisaoSimplificada}");
        }

        private static string SimplificarOperacao(int numerador, int denominador)
        {
            int numeroMaior = Math.Max(numerador, denominador);
            int numeradorFinal = numerador;
            int denominadorFinal = denominador;


            for (int i = numeroMaior; i > 1; i--)
            {
                if (numerador % i == 0 && denominador % i == 0)
                {
                    numerador = numeradorFinal = numerador / i;
                    denominador = denominadorFinal = denominador / i;
                }
            }

            return $"{numeradorFinal}/{denominadorFinal}";
        }

        private static (int, int) ProcessFormula(string formula)
        {
            string[] values = formula.Split(' ');
            int n1 = int.Parse(values[0]);
            int d1 = int.Parse(values[2]);
            int n2 = int.Parse(values[4]);
            int d2 = int.Parse(values[6]);

            string operacao = values[3];

            switch(operacao)
            {
                case "+": return Soma(n1, d1, n2, d2);
                case "-": return Subtracao(n1, d1, n2, d2);
                case "*": return Multipliacao(n1, d1, n2, d2);
                default:
                    return Divisao(n1, d1, n2, d2);
            };
        }

        private static (int, int) Soma(int n1, int d1, int n2, int d2)
        {
            return ((n1 * d2 + n2 * d1), (d1 * d2));
        }

        private static (int, int) Subtracao(int n1, int d1, int n2, int d2)
        {
            return ((n1 * d2 - n2 * d1), (d1 * d2));
        }

        private static (int, int) Multipliacao(int n1, int d1, int n2, int d2)
        {
            return ((n1 * n2), (d1 * d2));
        }

        private static (int, int) Divisao(int n1, int d1, int n2, int d2)
        {
            return ((n1 * d2), (n2 * d1));
        }
    }
}
