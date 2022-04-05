using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receitasNoLivro = 2;
            bool igual = false;
            Receita[] LivroReceitas = new Receita[receitasNoLivro];

            for (int j =0; j < receitasNoLivro; j++)
            {
                Console.WriteLine($"{j+1}° RECEITA ----------------------");

                Console.Write("\nDigite o nome da receita: ");
                string nome = Console.ReadLine();
                if(nome.Length > 25)
                {
                    nome = nome.Substring(0, 25);
                }


                Console.Write("\nDigite a quantidade de ingredientes: ");
                int quantidadeIngredientes = int.Parse(Console.ReadLine());

                string[,] ingredientes = new string[quantidadeIngredientes,2];

                for (int i = 0; i < quantidadeIngredientes; i++)
                {
                    Console.Write($"\n{i + 1}° ingrediente: ");
                    ingredientes[i,0] = Console.ReadLine();
                    Console.Write("Quantidade: ");
                    ingredientes[i, 1] = Console.ReadLine();
                }

                LivroReceitas[j] = new Receita(nome, quantidadeIngredientes, ingredientes);
                Console.WriteLine("");
            }

       
            Console.Write("\n-------------------------------------------------------------------------\nDigite o nome da receita que deseja procurar: ");
            string NomeReceita = Console.ReadLine();



            foreach (Receita receita in LivroReceitas)
            {
                if (receita.Nome == NomeReceita)
                {
                    igual = true;
                    Console.WriteLine("\nLista de Ingredientes\n");

                    for(int i = 0; i < receita.QuantidadeIngredientes; i++)
                    {
                        Console.WriteLine($"\nIngrediente: {receita.Ingredientes[i,0]}\nQuantidade {receita.Ingredientes[i,1]}");
                    }
                }
            }

            if (!igual)
            {
                Console.WriteLine("Nenhuma receia com esse nome no livro");
            }
            
        }

       
    }
    struct Receita // ARMAZENA UMA RECEITA
    {
        private string nome;
        private int quantidadeIngredientes;
        private string[,] ingredientes;

        public Receita(string nome, int quantidadeIngredientes, string[,] ingredientes)
        {
            this.nome = nome;
            this.quantidadeIngredientes = quantidadeIngredientes;
            this.ingredientes = ingredientes;
        }

        public string Nome { get => nome; set => nome = value; }
        public int QuantidadeIngredientes { get => quantidadeIngredientes; set => quantidadeIngredientes = value; }
        public string[,] Ingredientes { get => ingredientes; set => ingredientes = value; }
    }
}
