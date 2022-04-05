using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            bool trocou = false;

            Console.Write("Digite uma frase: ");

            char[] frase = Console.ReadLine().ToCharArray();
            string[] trocado = new string[frase.Length];

            for(int i = 0; i < frase.Length; i++)
            {
                
                trocou = false;

                if (!trocou)
                {
                    for (int j = 0; j < letras.Length; j++)
                    {
                        if (frase[i] == letras[j])
                        {

                            trocado[i] = ((j + 1).ToString());
                            trocou = true;
                        }
                    }
                }


                if (!trocou)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (frase[i] == char.Parse(j.ToString()))
                        {
                            trocado[i] = letras[j].ToString();
                            trocou = true;
                        }
                    }
                }

                if (!trocou)
                {
                    trocado[i] = frase[i].ToString();
                }
                
                
            
            }
            
            string[] comSeparador = new string[trocado.Length*2];

            int l = 0;
            for(int i = 0;i < comSeparador.Length; i++)
            {
                if(i % 2 != 0)
                {
                    comSeparador[i] = "_";
                }
                else
                {
                    comSeparador[i] = trocado[l];
                    l++;
                }
            }

            for(int i = 0; i < comSeparador.Length-1; i++)
            {
                Console.Write($"{comSeparador[i]}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
