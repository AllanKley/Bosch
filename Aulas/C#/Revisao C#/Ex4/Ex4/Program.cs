using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex4
{
    class Jogador
    {
        private int id;
        private string nome;
        private string apelido;
        private DateTime dataNascimento;
        private int numero;
        private string posicao;
        private double qualidade;
        private int cartaoAmarelo;
        private int cartaoVermelho;
        private bool suspenso;
        private bool fezTreinamento;

        public Jogador() { }
        public Jogador(int id, string nome, string apelido, DateTime dataNascimento, int numero, string posicao, double qualidade, int cartaoAmarelo, int cartaoVermelho, bool suspenso)
        {
            this.Id = id;
            this.Nome = nome;
            this.Apelido = apelido;
            this.DataNascimento = dataNascimento;
            this.Numero = numero;
            this.Posicao = posicao;
            this.Qualidade = qualidade;
            this.CartaoAmarelo = cartaoAmarelo;
            this.CartaoVermelho = cartaoVermelho;
            this.Suspenso = suspenso;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Posicao { get => posicao; set => posicao = value; }
        public double Qualidade { get => qualidade; set => qualidade = value; }
        public int CartaoAmarelo { get => cartaoAmarelo; set => cartaoAmarelo = value; }
        public int CartaoVermelho { get => cartaoVermelho; set => cartaoVermelho = value; }
        public bool Suspenso { get => suspenso; set => suspenso = value; }

        public string VerificarCondicaoDeJogo()
        {
            if ((cartaoAmarelo >= 3) || (cartaoVermelho == 1) || (suspenso == true))
            {
                suspenso = true;
                return "SUSPENSO";
            }
            else
            {
                suspenso=false;
                return "TÁ PRA JOGO";
            }
        }
        public void AplicarCartao(int quantidade, int tipo)
        {
            if(tipo == 1)
            {
                CartaoAmarelo += quantidade;
            }else if(tipo == 2)
            {
                CartaoVermelho += quantidade;
            }

        }
        public void CumprirSuspensao()
        {
            cartaoAmarelo = 0;
            cartaoVermelho = 0;
            suspenso = false;
        }
        public void SofrerLesao()
        {
            bool lesao = false;
            while (!lesao)
            {
                Random rand = new Random();
                int randInt = rand.Next(1, 101);

                if (randInt <= 5)
                {
                    if (qualidade * 0.85 >= 0)
                    {
                        lesao = true;
                        qualidade *= 0.85;
                    }
                    else
                    {
                        lesao = false;
                    }
                }
                else if (randInt <= 15)
                {
                    if (qualidade * 0.9 >= 0)
                    {
                        lesao = true;
                        qualidade *= 0.9;
                    }
                    else
                    {
                        lesao = false;
                    }
                }
                else if (randInt <= 30)
                {
                    if (qualidade * 0.95 >= 0)
                    {
                        lesao = true;
                        qualidade *= 0.95;
                    }
                    else
                    {
                        lesao = false;
                    }
                }
                else if (randInt <= 60)
                {
                    if (qualidade - 2 >= 0)
                    {
                        lesao = true;
                        qualidade -= 2;
                    }
                    else
                    {
                        lesao = false;
                    }
                }
                else
                {
                    if (qualidade - 1 >= 0)
                    {
                        lesao = true;
                        qualidade -= 1;
                    }
                    else
                    {
                        lesao = false;
                    }
                }
            }
            
        }
        public void ExecutarTreinamento()
        {
            if (!fezTreinamento)
            {
                bool treinamento = false;
                fezTreinamento = true;
                while (!treinamento)
                {
                    Random rand = new Random();
                    int randInt = rand.Next(1, 101);

                    if (randInt <= 5)
                    {
                        if (qualidade + 5 <= 100)
                        {
                            treinamento = true;
                            qualidade += 5;
                        }
                        else
                        {
                            treinamento = false;
                        }
                    }
                    else if (randInt <= 15)
                    {
                        if (qualidade + 4 <= 100)
                        {
                            treinamento = true;
                            qualidade += 4;
                        }
                        else
                        {
                            treinamento = false;
                        }
                    }
                    else if (randInt <= 30)
                    {
                        if (qualidade + 3 <= 100)
                        {
                            treinamento = true;
                            qualidade += 3;
                        }
                        else
                        {
                            treinamento = false;
                        }
                    }
                    else if (randInt <= 60)
                    {
                        if (qualidade + 2 <= 100)
                        {
                            treinamento = true;
                            qualidade += 2;
                        }
                        else
                        {
                            treinamento = false;
                        }
                    }
                    else
                    {
                        if (qualidade + 1 <= 100)
                        {
                            treinamento = true;
                            qualidade += 1;
                        }
                        else
                        {
                            treinamento = false;
                        }
                    }
                }
            }
            
        }
        public void Plantel()
        {
            Console.WriteLine($"\n\n{Posicao}: {Numero} - {Nome} ({Apelido}) - {DataNascimento.ToShortDateString()} CONDIÇÃO: {VerificarCondicaoDeJogo()}, QUALIDADE: {qualidade}, CARTÕES AMARELOS: {cartaoAmarelo}, CARTÕES VERMELHOS: {cartaoVermelho}");
        }
    }




    class Time
    {
        private string nome;
        private string apelido;
        private DateTime fundacao;
        private List<Jogador> plantel;
        private List<Jogador> relacionados;


        public Time() { }

        public Time(string nome, string apelido, DateTime fundacao, List<Jogador> plantel, List<Jogador> relacionados)
        {
            this.Nome = nome;
            this.Apelido = apelido;
            this.Fundacao = fundacao;
            this.Plantel = plantel;
            this.Relacionados = relacionados;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        internal List<Jogador> Plantel { get => plantel; set => plantel = value; }
        internal List<Jogador> Relacionados { get => relacionados; set => relacionados = value; }

        public void RelacionarJogadores()
        {
            int remover;

            string posicao="";
            int quantidade = 0;
            List<Jogador> melhores = new List<Jogador>();
            bool igual = false;
            // ORDENA LISTA
            melhores = plantel.OrderByDescending(x => x.Qualidade).ToList();

            for (int i = 0; i < 7; i++)
            {

                switch (i)
                {
                    case 0:
                        posicao = "Atacante";
                        quantidade = 3;
                        break;
                    case 1:
                        posicao = "Zagueiro";
                        quantidade = 2;
                        break;
                    case 2:
                        posicao = "Lateral Esquerdo";
                        quantidade = 1;
                        break;
                    case 3:
                        posicao = "Lateral Direito";
                        quantidade = 1;
                        break;
                    case 4:
                        posicao = "Meio-campista";
                        quantidade = 2;
                        break;
                    case 5:
                        posicao = "Volante";
                        quantidade = 1;
                        break;
                    case 6:
                        posicao = "Goleiro";
                        quantidade = 1;
                        break;
                }

                List<Jogador> posicoes = new List<Jogador>();

                // SEPARA POR POSICAO
                foreach (Jogador jogador in Plantel)
                {
                    if (jogador.Posicao == posicao)
                    {
                        posicoes.Add(jogador);
                    }
                }

                // ORDENA LISTA
                posicoes = posicoes.OrderByDescending(x => x.Qualidade).ToList();

                // PEGA 2 ULTIMOS
                remover = posicoes.Count() - quantidade;

                for (int x = 0; x < remover; x++)
                {
                    posicoes.RemoveAt(posicoes.Count() - 1);
                }

                //ADICIONA NOS RELACIONADOS
                foreach (Jogador jogador in posicoes)
                {
                
                    relacionados.Add(jogador);
                }
            }


            foreach(Jogador jogador in melhores)
            {
                igual = false;
                foreach(Jogador relacionado in relacionados)
                {
                    if (jogador.Id == relacionado.Id)
                    {
                        igual = true;
                    }
                }
                if (!igual)
                {
                    relacionados.Add(jogador);
                }
            }

            // PEGA 18
            remover = relacionados.Count() - 18;

            for (int x = 0; x < remover; x++)
            {
                relacionados.RemoveAt(relacionados.Count() - 1);
            }




        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<Time> times = new List<Time>();
            List<Jogador> plantel = new List<Jogador>();
            List<Jogador> relacionados = new List<Jogador>();
            int i = 0;

            plantel.Add(new Jogador(1, "Marcos", "Marcão", DateTime.ParseExact("04/09/1973", "dd/MM/yyyy", CultureInfo.InvariantCulture), 1, "Goleiro", 90, 0, 0, false));
            plantel.Add(new Jogador(2, "Cafú", "Capita", DateTime.ParseExact("07/06/1970", "dd/MM/yyyy", CultureInfo.InvariantCulture), 2, "Lateral Esquerdo", 100, 1, 0, false));
            plantel.Add(new Jogador(3, "Lúcio", "Lúcio", DateTime.ParseExact("08/03/1978", "dd/MM/yyyy", CultureInfo.InvariantCulture), 3, "Zagueiro", 70, 0, 0, false));
            plantel.Add(new Jogador(4, "Roque Júnior", "Roque", DateTime.ParseExact("03/08/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 4, "Zagueiro", 70, 1, 0, false));
            plantel.Add(new Jogador(5, "José Edmílson", "Edmílson", DateTime.ParseExact("07/07/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 5, "Zagueiro", 80, 0, 0, false));
            plantel.Add(new Jogador(6, "Roberto Carlos", "R6", DateTime.ParseExact("10/04/1973", "dd/MM/yyyy", CultureInfo.InvariantCulture), 6, "Lateral Direito", 100, 0, 0, false));
            plantel.Add(new Jogador(7, "Ricardo Luís", "Ricardinhos", DateTime.ParseExact("23/03/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 7, "Meio-campista", 80, 0, 1, true));
            plantel.Add(new Jogador(8, "Gilberto Silva", "Gilberto", DateTime.ParseExact("07/10/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 8, "Volante", 90, 1, 0, false));
            plantel.Add(new Jogador(9, "Ronaldo", "R9", DateTime.ParseExact("22/09/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 9, "Atacante", 10, 0, 0, false));
            plantel.Add(new Jogador(10, "Rivaldo Vítor", "Rivaldo", DateTime.ParseExact("19/04/1972", "dd/MM/yyyy", CultureInfo.InvariantCulture), 10, "Atacante", 95, 0, 0, false));
            plantel.Add(new Jogador(11, "Ronaldinho Gaúcho", "R10", DateTime.ParseExact("21/03/1980", "dd/MM/yyyy", CultureInfo.InvariantCulture), 11, "Meio-campista", 90, 0, 0, false));
            plantel.Add(new Jogador(12, "Marcos1", "Marcão", DateTime.ParseExact("04/09/1973", "dd/MM/yyyy", CultureInfo.InvariantCulture), 1, "Goleiro", 60, 0, 0, false));
            plantel.Add(new Jogador(13, "Cafú1", "Capita", DateTime.ParseExact("07/06/1970", "dd/MM/yyyy", CultureInfo.InvariantCulture), 2, "Lateral Esquerdo", 40, 1, 0, false));
            plantel.Add(new Jogador(14, "Lúcio1", "Lúcio", DateTime.ParseExact("08/03/1978", "dd/MM/yyyy", CultureInfo.InvariantCulture), 3, "Zagueiro", 80, 0, 0, false));
            plantel.Add(new Jogador(15, "Roque Júnior1", "Roque", DateTime.ParseExact("03/08/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 4, "Zagueiro", 78, 1, 0, false));
            plantel.Add(new Jogador(16, "José Edmílson1", "Edmílson", DateTime.ParseExact("07/07/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 5, "Zagueiro", 82, 0, 0, false));
            plantel.Add(new Jogador(17, "Roberto Carlos1", "R6", DateTime.ParseExact("10/04/1973", "dd/MM/yyyy", CultureInfo.InvariantCulture), 6, "Lateral Direito", 99, 0, 0, false));
            plantel.Add(new Jogador(18, "Ricardo Luís1", "Ricardinhos", DateTime.ParseExact("23/03/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 7, "Meio-campista", 43, 0, 1, true));
            plantel.Add(new Jogador(19, "Gilberto Silva1", "Gilberto", DateTime.ParseExact("07/10/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 8, "Volante", 73, 1, 0, false));
            plantel.Add(new Jogador(20, "Ronaldo1", "R9", DateTime.ParseExact("22/09/1976", "dd/MM/yyyy", CultureInfo.InvariantCulture), 9, "Atacante", 86, 0, 0, false));
            plantel.Add(new Jogador(21, "Rivaldo Vítor1", "Rivaldo", DateTime.ParseExact("19/04/1972", "dd/MM/yyyy", CultureInfo.InvariantCulture), 10, "Atacante", 65, 0, 0, false));
            plantel.Add(new Jogador(22, "Ronaldinho Gaúcho1", "R10", DateTime.ParseExact("21/03/1980", "dd/MM/yyyy", CultureInfo.InvariantCulture), 11, "Meio-campista", 23, 0, 0, false));
            plantel.Add(new Jogador(23, "kaka", "R10", DateTime.ParseExact("21/03/1980", "dd/MM/yyyy", CultureInfo.InvariantCulture), 18, "Meio-campista", 98, 0, 0, false));

            times.Add(new Time("Brazil", "Brazil 2002", DateTime.Parse("04/09/2002"), plantel, relacionados));

            times[0].RelacionarJogadores();

    

            foreach(Jogador jogador in relacionados)
            {
                if(i == 0)
                {
                    Console.WriteLine("\n\nTITULARES\n");
                }else if (i == 11)
                {
                    Console.WriteLine("\n\nRESERVAS\n");
                }
                jogador.Plantel();

                i++;
            }
            
            
          
        


        }
    }
}
