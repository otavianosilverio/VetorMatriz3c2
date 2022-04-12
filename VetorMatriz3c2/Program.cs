using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorMatriz3c2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercicio questao 1

            //int[,] notas = new int[2, 4];
            // int quantidade = 0;
            // estrutura de repeticao para linha e coluna
            // for (int linha = 0; linha < 2; linha++)
            // {
            //     for (int coluna = 0; coluna < 4; coluna++)
            //      {
            //         notas[linha, coluna] = random.Next(1, 50);
            //         Console.WriteLine(notas[linha, coluna]+"\t");
            //         if (notas[linha, coluna] >= 10 && notas[linha, coluna] <= 15)
            //          {
            //             quantidade++;
            //         }
            //      }

            //  }
            //   Console.WriteLine("quantidade"+quantidade);
            //    Console.ReadKey();
            //}
            // Questão 2
            Random random = new Random();
            int[,] matriz = new int[3, 2];
            int[] VetorA = new int[6];
            int[] VetorB = new int[6];
            int contPar = 0;
            int contImpar = 0;
            //
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna=0; coluna < 2; coluna++)
                {
                    matriz[linha, coluna] = random.Next(1, 50);
                    Console.WriteLine(matriz[linha, coluna] + "\t");
                    // verifica se o numero é par
                    if (matriz[linha, coluna] % 2 == 0)
                    {
                        VetorA[contPar] = matriz[linha, coluna];
                        contPar++;

                    }
                    else
                    {

                    }

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

    }
}
