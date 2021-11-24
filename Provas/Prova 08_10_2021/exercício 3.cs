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
            
            int valido = 0, cem=0,cinquenta=0,dez=0,cinco=0,um=0;
            decimal valor, tot;
            do
            {
                
                Console.WriteLine("Digite o valor que deseja sacar: ");
                valor = decimal.Parse(Console.ReadLine());
                if(valor>=10 && valor<=600)
                {
                    valido = 1;
                }
                
            } while (valido == 0);

            tot = valor;
            while (tot!=0)
            {
                if(tot/100>=1)
                {
                    cem++;
                    tot -= 100;
                }
                else if (tot/50>=1)
                {
                    cinquenta++;
                    tot -= 50;
                }
                else if (tot/10>=1)
                {
                    dez++;
                    tot -= 10;
                }
                else if (tot/5>=1)
                {
                    cinco++;
                    tot -= 5;
                }
                else if (tot/1>=1)
                {
                    um++;
                    tot -= 1;
                }
                
            }
            Console.WriteLine("Notas:\n100: {0}\n50: {1}\n10: {2}\n5: {3}\n1: {4}", cem, cinquenta, dez, cinco, um);
        }
    }
}
