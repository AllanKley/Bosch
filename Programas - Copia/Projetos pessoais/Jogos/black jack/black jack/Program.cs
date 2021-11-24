using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{

    class Baralho
    {
        public List<string> Valor = new List<string>() { "A", "A", "A", "A", "2", "2", "2", "2", "3", "3", "3", "3", "4", "4", "4", "4", "5", "5", "5", "5", "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "10", "J", "J", "J", "J", "Q", "Q", "Q", "Q", "K", "K", "K", "K"};
        public List<string> Naipe = new List<string>() { "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus", "ouro", "espadas", "copas", "paus" };
        public List<string> Carta = new List<string>() { "1", "1", "1", "1", "2", "2", "2", "2", "3", "3", "3", "3", "4", "4", "4", "4", "5", "5", "5", "5", "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10", "10" };
        string valor, naipe, carta;


        public Baralho() {}

        public string HitValor(int i)
        {
            valor = Valor[i];
            Valor.RemoveAt(i);
            return valor;
        }
        public string HitNaipe(int i)
        {
            naipe = Naipe[i];
            Naipe.RemoveAt(i);
            return naipe;
        }
        public string HitCarta(int i)
        {
            carta = Carta[i];
            Carta.RemoveAt(i);
            return carta;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            int menu = 1;
            float banco = 500, aposta=0;
            while (menu == 1)
            {
                // APOSTAS -------------------------------------------
                Console.WriteLine("Dinheiro no banco: {0}\n\nFaça sua aposta: ", banco);
                aposta=float.Parse(Console.ReadLine());
                Console.Clear();

                if(banco-aposta>=0)
                {
                    // INICIO DOS BARALHOS -------------------------------------------
                    List<string> PlayerValor = new List<string>();
                    List<string> PlayerNaipe = new List<string>();
                    List<string> PlayerCarta = new List<string>();
                    List<string> DealerValor = new List<string>();
                    List<string> DealerNaipe = new List<string>();
                    List<string> DealerCarta = new List<string>();
                    Baralho NovoBaralho = new Baralho();
                    int i, hit = 0, rodada = 1, DealerSoma = 0, PlayerSoma = 0, BlackJack = 0;

                    // COMPRA DE CARTAS -------------------------------------------
                    Random rnd = new Random();
                    for (int j = 0; j < 2; j++)
                    {
                        i = rnd.Next(0, NovoBaralho.Valor.Count - 1);
                        PlayerValor.Add(NovoBaralho.HitValor(i));
                        PlayerNaipe.Add(NovoBaralho.HitNaipe(i));
                        PlayerCarta.Add(NovoBaralho.HitCarta(i));
                    }

                    for (int j = 0; j < 2; j++)
                    {
                        i = rnd.Next(0, NovoBaralho.Valor.Count - 1);
                        DealerValor.Add(NovoBaralho.HitValor(i));
                        DealerNaipe.Add(NovoBaralho.HitNaipe(i));
                        DealerCarta.Add(NovoBaralho.HitCarta(i));
                    }

                    if ((PlayerCarta[0] == "A" && PlayerCarta[1] == "K") || (PlayerCarta[1] == "A" && PlayerCarta[0] == "K"))
                    {
                        hit = 2;
                        BlackJack = 1;
                    }
                    if ((DealerCarta[0] == "A" && DealerCarta[1] == "K") || (DealerCarta[1] == "A" && DealerCarta[0] == "K"))
                    {
                        hit = 2;
                        BlackJack = 1;
                    }


                    while (hit != 2)
                    {

                        if (rodada == 1)
                        {
                            Console.WriteLine("Cartas iniciais Dealer:\t_?_\t_{0}_ de {1}", DealerValor[1], DealerNaipe[1]);
                            Console.WriteLine("Suas cartas iniciais:\t_{0}_ de {1}\t_{2}_ de {3}", PlayerValor[0], PlayerNaipe[0], PlayerValor[1], PlayerNaipe[1]);
                        }
                        else
                        {
                            // COMPRA DE CARTAS -------------------------------------------
                            i = rnd.Next(0, NovoBaralho.Valor.Count - 1);
                            PlayerValor.Add(NovoBaralho.HitValor(i));
                            PlayerNaipe.Add(NovoBaralho.HitNaipe(i));
                            PlayerCarta.Add(NovoBaralho.HitCarta(i));

                            DealerSoma = 0;
                            for (int j = 0; j < DealerValor.Count; j++)
                            {
                                DealerSoma += int.Parse(DealerCarta[j]);
                            }
                            if ((DealerSoma + int.Parse(NovoBaralho.HitCarta(i))) < 18)
                            {
                                
                                DealerValor.Add(NovoBaralho.HitValor(i));
                                DealerNaipe.Add(NovoBaralho.HitNaipe(i));
                                DealerCarta.Add(NovoBaralho.HitCarta(i));
                            }

                            // VERIFICAR VITORIA PLAYER
                            PlayerSoma = 0;
                            for (int j = 0; j < PlayerValor.Count; j++)
                            {
                                PlayerSoma += int.Parse(PlayerCarta[j]);
                            }
                            if (PlayerSoma > 21)
                            {
                                break;
                            }

                            Console.WriteLine("Cartas iniciais Dealer:\t_?_\t_{0}_ de {1}", DealerValor[1], DealerNaipe[1]);
                            Console.WriteLine("Suas cartas iniciais:\t_{0}_ de {1}\t_{2}_ de {3}\n", PlayerValor[0], PlayerNaipe[0], PlayerValor[1], PlayerNaipe[1]);

                            for (int j = 2; j < PlayerValor.Count; j++)
                            {
                                Console.WriteLine("Hit {0}:\t_{1}_ de {2}", j - 1, PlayerValor[j], PlayerNaipe[j]);
                            }

                        }
                        Console.WriteLine("\n\nEscolha\n(1) Hit\n(2) Stand");
                        hit = int.Parse(Console.ReadLine());
                        rodada++;
                        Console.Clear();


                    }

                    PlayerSoma = 0;
                    for (int j = 0; j < PlayerValor.Count; j++)
                    {
                        PlayerSoma += int.Parse(PlayerCarta[j]);
                    }
                    DealerSoma = 0;
                    for (int j = 0; j < DealerValor.Count; j++)
                    {
                        DealerSoma += int.Parse(DealerCarta[j]);
                    }


                    if (BlackJack == 1)
                    {
                        if (PlayerSoma == 21)
                        {
                            Console.WriteLine("Vitoria por BlackJack!!\n\nSua pontuacao: 21\nPontuacao Dealer: {1}", DealerSoma);
                            banco += aposta;
                        }
                        else
                        {
                            Console.WriteLine("Derrota por BlackJack!!\n\nSua pontuacao: 21\nPontuacao Dealer: {1}", DealerSoma);
                            banco -= aposta;
                        }

                    }
                    else if (DealerSoma > PlayerSoma || PlayerSoma > 21)
                    {
                        Console.WriteLine("Derrota!!\n\nSua pontuacao: {0}\nPontuacao Dealer: {1}", PlayerSoma, DealerSoma);
                        banco -= aposta;
                    }
                    else if (DealerSoma < PlayerSoma)
                    {
                        Console.WriteLine("Vitoria!!\n\nSua pontuacao: {0}\nPontuacao Dealer: {1}", PlayerSoma, DealerSoma);
                        banco += aposta;
                    }
                    else
                    {
                        Console.WriteLine("Empate!!\n\nSua pontuacao: {0}\nPontuacao Dealer: {1}", PlayerSoma, DealerSoma);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    if(banco>0)
                    {
                        Console.WriteLine("Deseja continuar?\n(1) SIM\n(2) NÃO\n");
                        menu = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Fim de jogo!!");
                        menu = 2;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Aposta invalida");
                    Console.ReadKey();
                    Console.Clear();
                }

                
            }
        }
    }
}

