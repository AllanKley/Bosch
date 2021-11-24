using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> SP = new List<string>();
            List<string> PR = new List<string>();
            List<string> SC = new List<string>();
            int sp=0, pr=0, sc=0;
            Console.WriteLine("Digite quantos endereços deseja inserir: ");
            int quant = int.Parse(Console.ReadLine());
            for(int i = 0; i<quant;i++)
            {
                Console.WriteLine("Digite a rua: ");
                string rua = Console.ReadLine();
                Console.WriteLine("Digite o numero: ");
                string numero = Console.ReadLine();
                Console.WriteLine("Digite a cidade: ");
                string cidade = Console.ReadLine();
                Console.WriteLine("Digite o estado: ");
                string estado = Console.ReadLine();
                
                switch(estado)
                {
                    case "SP":
                        SP.Add(string.Format("{0},{1}-{2}/{3}",rua,numero,cidade,estado));
                        sp++;
                        break;
                    case "PR":
                        PR.Add(string.Format("{0},{1}-{2}/{3}", rua, numero, cidade, estado));
                        pr++;
                        break;
                    case "SC":
                        SC.Add(string.Format("{0},{1}-{2}/{3}", rua, numero, cidade, estado));
                        sc++;
                        break;
                }
                Console.Clear();
            }
            if(SP.Count!=0)
            {
                Console.WriteLine("\nSÃO PAULO:\n");
                SP.ForEach(Console.WriteLine);
            }
            if (PR.Count != 0)
            {
                Console.WriteLine("\nPARANÁ:\n");
                PR.ForEach(Console.WriteLine);
            }
            if (SC.Count != 0)
            {
                Console.WriteLine("\nSANTA CATARINA:\n");
                SC.ForEach(Console.WriteLine);
            }

        }
    }
}
