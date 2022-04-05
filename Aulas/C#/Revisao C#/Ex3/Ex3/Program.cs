using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Animal
    {
        private string nome;
        private string tipo;

        public Animal(string nome, string tipo)
        {
            this.Nome = nome;
            if((tipo == "Cachorro") || (tipo == "Gato") || (tipo == "Peixe"))
            {
                this.Tipo = tipo;
            }
            else
            {
                this.Tipo = "Peixe";
            } 
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimal = new List<Animal>();
            int cachorros=0;
            int gatos=0;
            int peixes=0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}° Animal");
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("\nTipo: ");
                string tipo = Console.ReadLine();

                Animal animal = new Animal(nome, tipo);

                listaAnimal.Add(animal);    
            }

            foreach(Animal animal in listaAnimal)
            {
                if (animal.Tipo == "Cachorro")
                {
                    cachorros++;
                }else if(animal.Tipo == "Gato")
                {
                    gatos++;
                }
                else
                {
                    peixes++; 
                }
            }
            Console.WriteLine($"\nGatos: {gatos}\nCachorros: {cachorros}\nPeixes: {peixes}");

        }
    }
}
