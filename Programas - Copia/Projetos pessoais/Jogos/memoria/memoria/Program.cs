using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_memoria
{

    class Deck
    {
        public List<string> deck = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "a", "b", "c", "d", "e", "f", "g", "h" };
        public List<string> deck2 = new List<string>() { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "." };


    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            int i = 0, rodada = 1, vitoria = 0;

            var rnd = new Random();
            var randomized = deck1.deck.OrderBy(item => rnd.Next());

            // PRINT DECK ???
            

            deck1.deck = randomized.ToList();

            ///*
            foreach (var value in deck1.deck)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(" {0} ", value);
                i++;
            }
            Console.WriteLine("\n\n");
            //*/


            while (vitoria != (deck1.deck.Count / 2))
            {

                Console.WriteLine("Rodada {0}", rodada);
                foreach (var value in deck1.deck2)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(" {0} ", value);
                    i++;
                }
                Console.WriteLine("\n\n");

                
                Console.WriteLine("Digite a linha que deseja abrir");
                int linha1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a coluna que deseja abrir");
                int coluna1 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Rodada {0}", rodada);
                int coordenada1 = ((4 * (linha1 - 1)) + coluna1) - 1;
                i = 0;
                
                foreach (var value in deck1.deck2)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("");
                    }

                    if (i == (coordenada1))
                    {
                        Console.Write(" {0} ", deck1.deck[i]);
                    }
                    else
                    {
                        Console.Write(" {0} ", value);
                    }

                    i++;
                }
                
                Console.WriteLine("\n\nDigite a linha que deseja abrir");
                int linha2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a coluna que deseja abrir");
                int coluna2 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Rodada {0}", rodada);
                int coordenada2 = ((4 * (linha2 - 1)) + coluna2) - 1;
                
                i = 0;

                foreach (var value in deck1.deck2)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("");
                    }

                    if ((i == (coordenada1)) || (i == (coordenada2)))
                    {
                        Console.Write(" {0} ", deck1.deck[i]);
                    }
                    else
                    {
                        Console.Write(" {0} ", value);
                    }

                    i++;
                }

                if (deck1.deck[coordenada1] == deck1.deck[coordenada2])
                {
                    deck1.deck2[coordenada1] = deck1.deck[coordenada1];
                    deck1.deck2[coordenada2] = deck1.deck[coordenada2];
                    vitoria++;
                }

                rodada++;

                Console.WriteLine("\n\nProxima rodada");
                Console.ReadKey();
                Console.Clear();

            }


            Console.Clear();
            Console.WriteLine("VITORIA!!!");

            foreach (var value in deck1.deck2)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(" {0} ", value);
                i++;
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();

        }
    }


}
