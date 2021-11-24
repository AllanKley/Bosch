using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Pessoas
    {
        public string nome, altura, nascimento;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<string> removidos = new List<string>();
            List<string> palindromo = new List<string>();
            string palavra, removido="", invertido="";
            int cont = 0, j=0;
            do
            {
                Console.WriteLine("Digite uma palavra/frase: ");
                palavra = Console.ReadLine();
                if (palavra != "")
                {
                    input.Add(palavra);
                    cont++;
                    
                }
                Console.Clear();
            } while (palavra != "");

            string[] palavras = new string[cont];

            foreach(string a in input)
            {
                palavras[j] = a;
                j++;
            }

            for (int i=0;i<palavras.Length; i++)
            {
                for(int a=0;a< palavras[i].Length; a++)
                {
                    if(palavras[i][a]!=' ')
                    {
                        removido += palavras[i][a];
                    }   
                }
                removidos.Add(removido);
                removido = "";
            }
            
             for (int i=0;i<removidos.Count; i++)
            {
                for(int a=removidos[i].Length;a>0;a--)
                {  
                        invertido += removidos[i][a-1];
                }

                if (removidos[i]==invertido)
                {
                    palindromo.Add(palavras[i]);
                }
                
                invertido = "";
            }

            Console.WriteLine("Palindromos: ");
            palindromo.ForEach(Console.WriteLine);

        }
    }
}
