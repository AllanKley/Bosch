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

            Random r = new Random();
            int comp = r.Next(1, 4);
            int vitoria=1, cont=0, emp=0;
            List<string> jogadas = new List<string>();
            jogadas.Add("Pedra");
            jogadas.Add("Papel");
            jogadas.Add("Tesoura");


            do
            {
                Console.WriteLine("Escolha sua jogada\n(1)\tPedra\n(2)\tPapel\n(3)\tTesoura\n");
                int jog = int.Parse(Console.ReadLine());

                if ((jog == (comp + 1)) || (jog == (comp - 2)))
                {
                    Console.WriteLine("Voce ganhou!!\nSua jogada: {0}\n Jogada Computador: {1}", jogadas[jog-1], jogadas[comp - 1]);
                    vitoria = 1;
                    cont++;
                }
                else if(jog==comp)
                {
                    Console.WriteLine("Empate!!\nSua jogada: {0}\n Jogada Computador: {1}", jogadas[jog - 1], jogadas[comp - 1]);
                    vitoria = 1;
                    emp++;
                }
                else
                {
                    Console.WriteLine("Voce perdeu!!\nSua jogada: {0}\n Jogada Computador: {1}", jogadas[jog - 1], jogadas[comp - 1]);
                    vitoria = 0;
                }
                Console.ReadKey();
                Console.Clear();
            } while (vitoria == 1);

            Console.WriteLine("Fim de jogo\nVitorias: {0}\nEmpates: {1}", cont, emp);
        }
    }
}
