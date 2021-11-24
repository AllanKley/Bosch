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

            Pessoas[] vetor = new Pessoas[10];
            int cont = 0, menu=1;

            do
            {
                Pessoas pessoa = new Pessoas();

                if (menu == 1)
                {
                    Console.WriteLine("Digite seu nome: ");
                    pessoa.nome = (Console.ReadLine());
                    Console.WriteLine("Digite sua altura: ");
                    pessoa.altura = (Console.ReadLine());
                    Console.WriteLine("Digite sua data de nascimento: ");
                    pessoa.nascimento = (Console.ReadLine());

                    vetor[cont] = pessoa;
                    
                    cont++;
                   
                }else if (menu == 2)
                {
                    for (int i = 0; i < cont; i++)
                    {
                        Console.WriteLine("Nome: {0}\nAltura: {1}\nData de nascimento: {2}\n", vetor[i].nome, vetor[i].altura, vetor[i].nascimento);    
                    }
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("Menu:\n1 - Inserir nova pessoa\n2 - Listar pessoas\n3 - Sair");
                menu = int.Parse(Console.ReadLine());

            } while (menu != 3);
            

            
        }
    }
}
