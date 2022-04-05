using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public void ExibirDados()
        {
            Console.WriteLine($"\n\nNome: {_nome}\nIdade: {_idade}");
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int _MaiorIdade=0;
            string _MaiorIdadeNome="";
            List<Pessoa> listaPessoas = new List<Pessoa>();

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"\n\nDigite o nome da {i + 1}° pessoa: ");
                string nome = Console.ReadLine();
                Console.Write($"\nDigite a idade da {i + 1}° pessoa: ");
                int idade = int.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(nome, idade);
                listaPessoas.Add(pessoa);
            }


            for(int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    _MaiorIdade = listaPessoas[i].Idade;
                    _MaiorIdadeNome = listaPessoas[i].Nome;
                }
                else
                {
                    if (_MaiorIdade < listaPessoas[i].Idade)
                    {
                        _MaiorIdade = listaPessoas[i].Idade;
                        _MaiorIdadeNome = listaPessoas[i].Nome;
                    }
                }

                listaPessoas[i].ExibirDados();
            }
            Console.WriteLine($"\nA pessoa mais velha eh: {_MaiorIdadeNome}, com {_MaiorIdade} anos de idade");
            
            

        }
    }
}
