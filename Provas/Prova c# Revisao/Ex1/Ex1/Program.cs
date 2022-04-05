using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> ListaChar = new List<char>();
            bool parar = false;

            do
            {
                Console.WriteLine("Deseja acrescentar um caractere a lista?\n1 - SIM\n2 - NÃO");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\nDigite o caractere desejado: ");
                        ListaChar.Add(char.Parse(Console.ReadLine()));
                        ListaChar.Sort();
                        Console.Write("\nLista Ordenada: ");
                        foreach(char c in ListaChar)
                        {
                            Console.Write($"{c} ");
                        }                  
                        break;
                    case 2:
                        parar = true;
                        break;
                    default:
                        Console.WriteLine("Input invalido");
                        break;
                }   
                Console.WriteLine("\n ------------------------------------------ \n");
            } while (!parar);
    
        }

       
    }
}
