using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] aleatorio = new int[5,5];
            int[,] semImpares = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    
                    int randInt = rand.Next(1, 101);
                    aleatorio[i,j] = randInt;
                }
            }
            Console.WriteLine("\n COM OS IMPARES\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{aleatorio[i,j]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n SEM OS IMPARES\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(aleatorio[i,j] % 2 != 0)
                    {
                        semImpares[i, j] = 0;
                    }
                    else
                    {
                        semImpares[i, j] = aleatorio[i,j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{semImpares[i, j]}\t");
                }
                Console.WriteLine("");
            }



        }
    }
}
