using System;

namespace exercicio_2
{
    class Program
    {
        static void Main()
        {

            // TROCA DE VALORES
            {
                /*
                int val1, val2, val3;
                Console.WriteLine("digite o primeiro valor: ");
                val1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo valor: ");
                val2 = int.Parse(Console.ReadLine());

                val3 = val1;
                val1 = val2;
                val2 = val3;
                Console.WriteLine("\no novo valor 1 é: {0} e o novo valor 2 é: {1}",val1,val2
                */
            }

            // CONVERSÂO TEMPERATURA
            {
                /*
                float menu, celc, fahr;

                Console.WriteLine("MENU:\n(1)\tCelcius para Fahrenheit\n(2)\tFahrenheit para Celcius");
                menu = float.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("digite a temperatura em Celcius: ");
                        celc = float.Parse(Console.ReadLine());
                        fahr = ((9 * celc) + 160) / 5;

                        Console.WriteLine("a temperatura em Fahrenheit é: {0}", fahr);
                        break;

                    case 2:
                        Console.WriteLine("digite a temperatura em Fahrenhei: ");
                        fahr = float.Parse(Console.ReadLine());
                        celc = ((fahr * 5) - 160) / 9; 

                        Console.WriteLine("a temperatura em Celcius é: {0}", celc);
                        break;

                    default:
                        Console.WriteLine("input inválido");
                        break;
                }
                */
            }

            // CONVERSÂO DOLAR E REAL
            {
                /*
                float menu, real, dolar, cot;

                Console.WriteLine("MENU:\n(1)\tReal para Dolar\n(2)\tDolar para Real");
                menu = float.Parse(Console.ReadLine());

                Console.WriteLine("digite a cotação do Dolar atual: ");
                cot = float.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("digite o valor em Real: ");
                        real = float.Parse(Console.ReadLine());
                        dolar = real / cot;

                        Console.WriteLine("\no valor em Dolar é: {0}", dolar);
                        break;

                    case 2:
                        Console.WriteLine("digite o valor em Dolar: ");
                        dolar = float.Parse(Console.ReadLine());
                        real = dolar * cot;

                        Console.WriteLine("\no valor em Reais é: {0}", real);
                        break;

                    default:
                        Console.WriteLine("input inválido");
                        break;
                }
                */
            }

            // OPERADORES DE ATRIBUIÇÃO
            {
                /*
                float sum = 10, div = 10, sub = 10, mult = 10, resto = 10;

                for (int i = 0;  i < 5 ; i++)
                {
                    Console.WriteLine("+= : {0};\t -= : {1};\t *= : {2};\t /= : {3};\t %= : {4};", sum, sub, mult, div, resto);
                    sum += 2;
                    div /= 2;
                    sub -= 2;
                    mult *= 2;
                    resto %= 2;
                }
                */
            }

            // NUMEROS EM ORDEM DECRESCENTE
            {
                /*
                int n1, n2, n3, i;

                Console.WriteLine("digite o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o terceiro numero: ");
                n3 = int.Parse(Console.ReadLine());

                while (n1>n2 || n2>n3 || n1 > n3)
                {
                    if (n1>n2)
                    {
                        i = n2;
                        n2 = n1;
                        n1 = i;
                    }
                    else if (n2>n3)
                    {
                        i = n3;
                        n3 = n2;
                        n2 = i;
                    }
                }

                Console.WriteLine("Ordem decrescente: {0}; {1}; {2}", n3, n2, n1);
                */
            }

            // MÉDIA PONDERADA
            {
                /*
                float n1, n2, med, p1, p2;

                Console.WriteLine("digite a primeira nota: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a segunda nota: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o peso da P1: ");
                p1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o peso da P2: ");
                p2 = int.Parse(Console.ReadLine());

                med = ((n1*p1)+(n2*p2))/(p1 + p2);
                Console.WriteLine("\nA média é: {0}", med);
                */
            }

            // BYTES TO GIGABYTES
            {
                /*
                float bit, gig;

                Console.WriteLine("digite o valor em bytes: ");
                bit= int.Parse(Console.ReadLine());
                gig = ((bit / 1024) / 1024) / 1024;
                Console.WriteLine("O vaor em Gigabytes é: {0}",gig);
                */
            }

            // IMC
            {
                /*
                float peso, alt, imc;

                Console.WriteLine("digite seu peso: ");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("digite sua altura: ");
                alt = float.Parse(Console.ReadLine());

                imc = peso / (alt * alt);

                if (imc < 20)
                { 
                    Console.WriteLine("abaixo do peso");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("peso normal}");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("acima do peso");
                }
                else 
                {
                    Console.WriteLine("obesidade");
                }         
                */
            }

            // AREA RETANGULO
            {
                /*
                float bas,alt,area;

                Console.WriteLine("digite a base do retangulo: ");
                bas = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a altura do retangulo: ");
                alt = float.Parse(Console.ReadLine());

                area = bas * alt;

                Console.WriteLine("A area do retangulo é: {0}",area);
                */
            }

            // POSITIVO E NEGATIVO
            {
                /*
                int num1;

                Console.WriteLine("digite um numero: ");
                num1 = int.Parse(Console.ReadLine());

                if (num1 < 0)
                {
                    Console.WriteLine("negativo");
                }
                else 
                {
                    Console.WriteLine("positivo");
                }
                */
            }

            // BANCO
            {
                /*
                float saldo=0, conta, op, menu;
                bool sair = false;

                while (sair == false)
                {

                    Console.WriteLine("MENU:\n(1)\tSaldo\n(2)\tSacar\n(3)\tDepositar\n(4)\tSair\n");
                    menu = float.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("\nSaldo: {0} R$", saldo);
                            Console.WriteLine("\n\nDigite qualquer tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("\ndigite o valor que deseja sacar: \n");
                            op = float.Parse(Console.ReadLine());
                            if ((saldo-op)>0)
                            {
                                saldo -= op;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nSaldo insuficiente");
                                Console.WriteLine("\n\nDigite qualquer tecla para continuar\n");
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            Console.WriteLine("\ndigite o valor que deseja depositar: \n");
                            op = float.Parse(Console.ReadLine());
                            saldo += op;
                            break;
                        case 4:
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("\ninput inválido");
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                }
                */
            }

            // Matriz (maior e menor)
            {
                /*
                int[] matriz = new int[10];
                int maior=0, menor=0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("digite o {0} valor", (i + 1));
                    matriz[i] = int.Parse(Console.ReadLine());
                }

                for (int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    {
                        maior = matriz[j];
                        menor = matriz[j];
                    }
                    else 
                    {
                        if (maior < matriz[j])
                        {
                            maior = matriz[j];
                        }
                        if (menor > matriz[j])
                        {
                            menor = matriz[j];
                        }
                    }
                }
                Console.WriteLine("\n: {0}\t Menor: {1}", maior, menor);
                */
            }





        }
    }
}
