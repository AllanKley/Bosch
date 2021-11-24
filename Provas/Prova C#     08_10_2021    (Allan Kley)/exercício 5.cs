using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            string produto,valor;
            List<string> prod = new List<string>();
            List<string> val = new List<string>();
            do
            {
                Console.WriteLine("Digite o nome do produto: ");
                produto = Console.ReadLine();
                
                if (produto != "")
                {
                    Console.WriteLine("Digite o valor do produto: ");
                    valor = Console.ReadLine();
                    prod.Add(produto);
                    val.Add(valor);
                }
                Console.Clear();
            } while (produto != "");


            for(int a=0; a<prod.Count;a++)
            {
                Console.WriteLine("Produto: {0}\nValor: R$ {1}\n",prod[a],val[a]);
            }
        }
    }
}
