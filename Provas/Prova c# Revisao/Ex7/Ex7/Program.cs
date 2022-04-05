using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class VooGeral : ICloneable
    {
        private int numeroVoo;
        private DateTime data;
        private int vagas = 100;
        private List<int> ocupadas;
        bool ocupada;
        public VooGeral(int numeroVoo, DateTime data)
        {
            this.NumeroVoo = numeroVoo;
            this.Data = data;
        }

        public int NumeroVoo { get => numeroVoo; set => numeroVoo = value; }
        public DateTime Data { get => data; set => data = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Ocupa(int cadeira)
        {
            ocupada = false;

            foreach(int x in ocupadas)
            {
                if(cadeira == x)
                {
                    ocupada=true;
                }
            }
            if (!ocupada)
            {
                ocupadas.Add(cadeira);
            }
        }
        public int Vagas()
        {
            return vagas - ocupadas.Count;
        }
        public bool Verifica(int cadeira)
        {
            ocupada = false;
            foreach (int x in ocupadas)
            {
                if (cadeira == x)
                {
                    ocupada = true;
                }
            }
            return ocupada;
        }
        public int ProximoLivre()
        {
            int i = 0;
            foreach (int x in ocupadas)
            {
                if (i == x)
                {
                    ocupada = true;
                }
            }
            if (!ocupada)
            {
                return i;
            }
            i++;
        }
    }

    class VooEspecifico : VooGeral
    {
        private int maxVagas;
        private int cadeirasFumantes;

        public VooEspecifico(int numeroVoo, DateTime data, int maxVagas, int cadeirasFumantes) : base(numeroVoo, data)
        {
            this.NumeroVoo = numeroVoo;
            this.Data = data;
            this.MaxVagas = maxVagas;
            this.CadeirasFumantes = cadeirasFumantes;
        }

        public int MaxVagas { get => maxVagas; set => maxVagas = value; }
        public int CadeirasFumantes { get => cadeirasFumantes; set => cadeirasFumantes = value; }

        public void DefineMaxVagas(int maxVagas)
        {
            this.MaxVagas = maxVagas;
        }
        public void DefineCadeirasFumantes(int cadeirasFumantes)
        {
            this.CadeirasFumantes = cadeirasFumantes;
        }
        public string Tipo(int cadeira)
        {
            if(cadeira >= (maxVagas - cadeirasFumantes))
            {
                return "F";
            }
            else
            {
                return "N";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
