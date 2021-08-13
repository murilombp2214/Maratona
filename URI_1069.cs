using System;
//1069
namespace URI
{
    class Program
    {
        const char diamente_E = '<';
        const char diamente_D = '>';
        const char areia = '.';

        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            while (n-- != 0)
            {
                Console.WriteLine(ObtenhaQuantidadeDeDiamantes(Console.ReadLine()));
            }
        }

        private static int ObtenhaQuantidadeDeDiamantes(string linha)
        {
            int qtd = 0;
            string atual = string.Empty;
            int cursor = 0;
            int posIncial = 0;
            while (cursor < linha.Length)
            {
                if (linha[cursor] == diamente_E)
                {
                    atual = "<";
                    posIncial = cursor;
                }
                else
                {
                    if (!string.IsNullOrEmpty(atual))
                    {
                        if (linha[cursor] == areia)
                        {
                            atual += ".";
                        }
                        else
                        {
                            qtd++;
                            atual += ">";
                            linha = linha.Remove(posIncial, atual.Length);
                            cursor = -1;
                            posIncial = 0;
                            atual = string.Empty;
                        }
                    }

                }
                cursor++;

            }

            return qtd;
        }
    }
}
