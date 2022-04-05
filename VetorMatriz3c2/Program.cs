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
            Random random = new Random();
            int[] idade = new int[10];
            int soma = 0;
             
            for (int x =0; x < idade.Length; x++)
            {
                idade[x] = random.Next(1,10);
                soma = soma + idade[x];
            }
            // imprimir o conteudo do veto
            for (int x = 0; x < idade.Length; x++)
            {
                Console.WriteLine(idade[x]);
            }
            Console.WriteLine("Soma "+soma);

            Console.ReadKey();

            // Criação de Matriz
            int[,] notas = new int[6, 2];
            // estrutura de repeticao para linha e coluna
            for (int linha = 0; linha < 6; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    notas[linha, coluna] = random.Next(1, 10);
                    Console.WriteLine(notas[linha, coluna]+"\t");
                }
              
            }

            Console.ReadKey();
        }
    }
}
