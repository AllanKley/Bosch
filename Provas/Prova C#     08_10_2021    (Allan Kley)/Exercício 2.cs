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

            Console.WriteLine("Digite a data: DD/MM/AAAA");
            string data = Console.ReadLine();
            Console.WriteLine("Digite o horario: 00:00:00");
            string horario = Console.ReadLine();

            var str = data + " " + horario;
            DateTime dt1;

            var isValidDate = DateTime.TryParse(str, out dt1);

            if (isValidDate)
            { 
                var dt2 = new DateTime(2021, 10, 08, 14, 00, 00);

                TimeSpan result = dt2.Subtract(dt1);

                Console.WriteLine("Horas decorridas: {0:N2}", result.TotalHours);
            }
            else
            { 
                Console.WriteLine("input invalido");
            }
            
            

        }
    }
}
