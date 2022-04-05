using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class voo
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double emprestimo;
            double juros;
            double mensal;


            Console.Write("Digite o valor do empréstimo que deseja: ");
            emprestimo = double.Parse(Console.ReadLine());
            Console.Write("Digite a taxa de juros: ");
            juros = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor mensal que deseja pagar: ");
            mensal = double.Parse(Console.ReadLine());



            double restante = emprestimo;
            double jurosAcumulado = 0;
            double pago = 0;
            int meses = 0;
            double mensalLimpo = mensal * ((100 - juros) / 100);
            double ValorJuros = mensal * (juros / 100);


            while (restante - mensalLimpo >= 0)
            {
                restante -= mensalLimpo;
                jurosAcumulado += ValorJuros;
                meses++;

                Console.WriteLine($"\n\n{meses}° MES\na) valor em dinheiro dos juros pagos: {ValorJuros}\nb. valor em dinheiro aplicada no pagamento da dívida: {mensalLimpo}\nc. valor acumulado de juros já pagos: {jurosAcumulado}\nd. valor ainda por pagar do empréstimo no fim de cada mês: {restante}");
            }

            mensalLimpo = restante;
            ValorJuros = mensalLimpo * (juros / 100);
            mensal = mensalLimpo + ValorJuros;
            jurosAcumulado += ValorJuros;
            restante = 0;
            meses++;
            Console.WriteLine($"\n\n{meses}° MES\na) valor em dinheiro dos juros pagos: {ValorJuros}\nb. valor em dinheiro aplicada no pagamento da dívida: {mensalLimpo}\nc. valor acumulado de juros já pagos: {jurosAcumulado}\nd. valor ainda por pagar do empréstimo no fim de cada mês: {restante}");

            Console.WriteLine($"\nBALANÇO FINAL\nMeses totais: {meses}\nQuantidade ultima prestação {mensal}");
        } 
    }
}
