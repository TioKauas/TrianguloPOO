using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloPOO.ConsoleApp
{
    internal class Funcoes
    {
        public void validacaoDados(int Esq, int Dir, int Inf, bool valido)
        {
            int Conta1, Conta2, Conta3;

            Conta1 = Esq + Dir;
            Conta2 = Inf + Dir;
            Conta3 = Esq + Inf;

            if (Conta1 <= Inf || Conta2 <= Esq || Conta3 <= Dir)
            {
                Console.WriteLine();

                Console.WriteLine("Valores Inválidos: É necessário que a medida de " +
                    "qualquer um dos lados seja menor que a soma dos outros dois lados");

                Console.Write("Pressione qualquer botão...");
                Console.ReadKey();

                Console.Clear();

                valido = false;
            }
            else
            {
                valido = true;
            }

            return;
        }

        public void verificacaoDados(int Esq, int Dir, int Inf)
        {
            if (Dir == Esq && Dir != Inf)
            {
                Console.WriteLine("Este é um triângulo isósceles");
            }
            else if (Esq == Inf && Dir == Inf && Esq == Dir)
            {
                Console.WriteLine("Este é um triângulo equilátero");
            }
            else if (Dir != Esq && Dir != Inf && Esq != Inf)
            {
                Console.WriteLine("Este é um triângulo escaleno");
            }
            else
            {
                Console.WriteLine("Nada encontrando");
            }
        }
    }
}
