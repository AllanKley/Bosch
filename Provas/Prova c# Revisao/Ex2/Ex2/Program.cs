using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            List<double> ListaNumeros = new List<double>();
            string tipo = "";
            bool sair = false;

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o {i + 1}° numero: ");
                ListaNumeros.Add(double.Parse(Console.ReadLine()));
            }

            while (!sair)
            {
                Console.WriteLine("\nQual media deseja realizar?\n1 - Aritmética\n2 - Ponderada(3,3,4)\n3 - Harmônica");
                int resp = int.Parse(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        media = (ListaNumeros.Sum()) / 3;
                        tipo = "Aritmética";
                        sair = true;
                        break;
                    case 2:
                        media = ((ListaNumeros[0] * 3) + (ListaNumeros[1] * 3) + (ListaNumeros[2] * 4)) / 10;
                        tipo = "Ponderada";
                        sair = true;
                        break;
                    case 3:
                        media = 3 / ((1 / ListaNumeros[0]) + (1 / ListaNumeros[1]) + (1 / ListaNumeros[2]));
                        tipo = "Harmônica";
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Input inválido");
                        break;
                }
            }
           
            Console.WriteLine($"\nA media {tipo} é: {media}");


        }
    }
}
