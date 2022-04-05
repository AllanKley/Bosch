using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Base: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.Write($"\nAltura:");
            double l2 = double.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo(l1, l2);
            retangulo.ExibirDados();   
        }
    }

    

    class Retangulo
    {
        private double l1;
        private double l2;
        private double area;


        public Retangulo(double L1, double L2)
        {
            if (L1 < 0)
            {
                this.L1 = 1;
            }
            else
            {
                this.L1 = L1;
            }

            if (L2 < 0)
            {
                this.L2 = 1;
            }
            else
            {
                this.L2 = L2;
            }
        }

        public double L1 { get => l1; set => l1 = value; }
        public double L2 { get => l2; set => l2 = value; }
        public double Area1 { get => area; set => area = value; }

        public double Area()
        {
            Area1 = L1 * L2;
            return Area1;
        }

        public void ExibirDados()
        {
            Area();
            Console.WriteLine($"\n\nO quadrado de dimensões {l1} e {l2} possui área igual a: {area}");
        }
    }
}

    