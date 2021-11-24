using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PerguntaJogo
    {
        public List<string> perguntas = new List<string>() { "Qual a cor do ceu?", "Qual a cor da grama?", "Qual o cor do cavalo branco de napoleao?" };
        public List<string> respostas = new List<string>() { "azul", "verde", "marrom" };
    }

    class NovaPergunta : PerguntaJogo
    {
        public List<string> dicas = new List<string>() { "mesma cor do mar", "mesma cor da folhas das arvores", "nao e branco" };
    }


    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int escolha = r.Next(0, 3);

            PerguntaJogo p1 = new PerguntaJogo();

            Console.WriteLine("{0}\n",p1.perguntas[escolha]);
            string resposta = Console.ReadLine();
            Console.Clear();
            if (resposta == p1.respostas[escolha])
            {
                Console.WriteLine("Parabens voce acertou!!");
            }
            else
            {
                Console.WriteLine("Resposta errada!!\n");
                NovaPergunta p2 = new NovaPergunta();
                Console.WriteLine("Dica: {0}\n", p2.dicas[escolha]);
                string resposta2 = Console.ReadLine();
                Console.Clear();
                if (resposta2 == p2.respostas[escolha])
                {
                    Console.WriteLine("Parabens voce acertou!!");
                }
                else
                {
                    Console.WriteLine("Voce perdeu!!");
                }
            }
        }
    }
}