using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//1110
namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtdCrianca;
            while ((qtdCrianca = int.Parse(Console.ReadLine())) != 0)
            {
                var criancas = new LinkedList<KeyValuePair<string, int>>();
                while (qtdCrianca-- > 0)
                {
                    var @params = Console.ReadLine().Split(' ');
                   // var @params = new string[] { Console.ReadLine(), Console.ReadLine() };
                    criancas.AddLast(new KeyValuePair<string, int>(@params[0], int.Parse(@params[1])));
                }


                Console.WriteLine("Vencedor(a): {0}", CriancaVencedora(criancas));


            }


        }

        private static string CriancaVencedora(LinkedList<KeyValuePair<string, int>> criancas)
        {
            var begin = criancas.First.Value.Value % 2 != 0
                        ? criancas.First.Next
                        : criancas.Last;

            int count = criancas.First.Value.Value;
            while (criancas.Count > 1)
            {
                if (count % 2 != 0)
                {
                    while (count-- > 1)
                    {
                        if (begin.Next == null)
                            begin = criancas.First;
                        else
                            begin = begin.Next;
                    }
                }
                else
                {
                    while (count-- > 1)
                    {
                        if (begin.Previous == null)
                            begin = criancas.Last;
                        else
                            begin = begin.Previous;
                    }

                }

                var aux = begin.Value.Value % 2 != 0
                        ? begin.Next
                        : begin.Previous;

                if (aux == null)
                {
                    if (begin.Value.Value % 2 != 0)
                        aux = criancas.First;
                    else
                        aux = criancas.Last;
                }

                count = begin.Value.Value;
                criancas.Remove(begin.Value);
                begin = aux;
            }


            return criancas.First.Value.Key;


        }
    }
}
