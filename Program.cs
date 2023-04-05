using System.Drawing;

namespace TrianguloPOO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcoes F = new Funcoes();
            int Esq, Dir, Inf;
            int Conta1, Conta2, Conta3;
            bool valido = false;

            do
            {
                try
                {
                    Console.Write("Valor da face da direita: ");
                    Dir = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Valor da face da esquerda: ");
                    Esq = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Valor da face inferior: ");
                    Inf = Convert.ToInt32(Console.ReadLine());

                    F.validacaoDados(Dir, Esq, Inf, valido);

                    if (valido == true)
                    {
                        F.verificacaoDados(Dir, Esq, Inf);
                    }
                }
                catch (Exception)
                {
                    Console.Write("Preencha os campos com valores válidos...");
                    Console.ReadKey();

                    Console.Clear();
                }

            } while (true);
        }     
    }
}