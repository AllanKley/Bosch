using System;

namespace Exercícios_1
{
    class Program
    {
        static void Main()
        {
            string nome, numero1, numero2, op;
            int num1, num2;

            // Pega os dados de nome e numeros desejados
            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("\ndigite o primeiro numero: ");
            numero1 = Console.ReadLine();
            Console.WriteLine("\ndigite o segundo numero: ");
            numero2 = Console.ReadLine();
            Console.WriteLine("\ndigite o operador desejado: ");
            op = Console.ReadLine();
            
            
            // Converte as strings em int
            Int32.TryParse(numero1, out num1);
            Int32.TryParse(numero2, out num2);
            

            // Calcula e mostra o resultado da soma
            if (op == "+") { Console.WriteLine("\nbom dia, " + nome + ", o resultado da soma é: " + (num1 + num2)); }
            else if (op == "-") { Console.WriteLine("\nbom dia, " + nome + ", o resultado da subtração é: " + (num1 - num2)); }
            else if (op == "*") { Console.WriteLine("\nbom dia, " + nome + ", o resultado da multiplicação é: " + (num1 * num2)); }
            else if (op == "/") { Console.WriteLine("\nbom dia, " + nome + ", o resultado da divisão é: " + (num1 / num2)); }
            else if (op == "%") { Console.WriteLine("\nbom dia, " + nome + ", o resto da divisão é: " + (num1 % num2)); }
            else { Console.WriteLine("input inválido"); }


        }
    }
}






