/*
using System; 

public class Program {

  public static void Main(string[] args) {
    
    int l1,l2,l3;
    Console.WriteLine("Digite o primeiro lado do triangulo: ");
    l1=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo lado do triangulo: ");
    l2=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o terceiro lado do triangulo: ");
    l3=int.Parse(Console.ReadLine());

    if((l1<l2+l3) && (l2<l1+l3) && (l3<l1+l2))
    {
      if(l1==l2 && l2==l3)
      {
        Console.WriteLine("O tringulo e equilatero!!");
      }
      else if(l1==l2 || l2==l3 || l1==l3)
      {
        Console.WriteLine("O tringulo e isosceles!!");
      }
      else
      {
        Console.WriteLine("O tringulo e escaleno!!");
      }
    }
    else
    {
      Console.WriteLine("As medidas nao formam um triangulo!!");
    }
  }
}
*/
/*
using System; 

public class Program {

  public static void Main(string[] args) {

  int pos=0, neg=0, zero=0, j=0, p=0;
  int[] num= new int[5];
  

  for(int i = 0; i<5;i++)
  {
    Console.WriteLine("Digite o {0} numero: ",i+1);
    num[i]=int.Parse(Console.ReadLine()); 
  }
  for(int i=0;i<5;i++)
  {
    if(num[i]>0)
    {
      pos++;
    }
    else if (num[i]<0)
    {
      neg++;
    }
    else
    {
      zero++;
    }
  }
  int[] a= new int[pos];
  int[] b= new int[neg];
  for(int i=0;i<5;i++)
  {
    if(num[i]>0)
    {
      a[j]=num[i];
      j++;
    }
    else if (num[i]<0)
    {
      b[p]=num[i];
      p++;
    }
  }
  Console.WriteLine("\nPositivos:");
  for(int i=0;i<pos;i++)
  {
    Console.WriteLine("{0}",a[i]);
  }
  Console.WriteLine("\nNegativos:");
  for(int i=0;i<neg;i++)
  {
    Console.WriteLine("{0}",b[i]);
  }
  Console.WriteLine("\nNumero de zeros: {0}:", zero);
  }
}
*/
/*
using System; 

public class Program {

  public static void Main(string[] args) {
    int menu, num1, num2;

    Console.WriteLine("Digite o primeiro numero: ");
    num1=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2=int.Parse(Console.ReadLine());
    Console.Clear();
    do{
      Console.WriteLine("Menu:\n(1)\tVerificar multiplicidade\n(2)\tVerificar pares\n(3)\tVerificar Media\n(4)\tSair\n");
      menu=int.Parse(Console.ReadLine());
      switch(menu)
      {
        case 1:
        if((num1%num2)==0)
        {
          Console.WriteLine("\n{0} e multiplo de {1}",num1,num2);
        }
        else if((num2%num1)==0)
        {
          Console.WriteLine("\n{0} e multiplo de {1}",num2,num1);
        }
        else
        {
          Console.WriteLine("\nOs numeros nao sao multiplos");
        }
        Console.ReadKey();
        break;

        case 2:
        if((num1%2)==0)
        {
          Console.WriteLine("\n{0} e Par",num1);
        }
        if((num2%2)==0)
        {
          Console.WriteLine("\n{0} e Par",num2);
        }
        if((num1%2)!=0 && (num2%2)!=0)
        {
          Console.WriteLine("\nOs numeros nao sao Pares");
        }
        Console.ReadKey();
        break;

        case 3:
        Console.WriteLine("\nA media e: {0}",(num1+num2)/2);
        Console.ReadKey();
        break;

        case 4:
        break;

        default:
        Console.WriteLine("\nInput invalido");
        Console.ReadKey();
        break;
      }
      Console.Clear();
    }while (menu !=4);
  
  }
}
*/
/*
using System; 

public class Program {

  public static void Main(string[] args) {
    int quant, cont=0;
  
    Console.WriteLine("Digite a quantidade de numeros que quer digitar em cada lista: ");
    quant=int.Parse(Console.ReadLine());
    Console.Clear();

    int[] l1 = new int[quant];
    int[] l2 = new int[quant];

    for (int i=0; i<quant;i++)
    {
      Console.WriteLine("Digite o {0} numero da lista 1: ", i+1);
      l1[i]=int.Parse(Console.ReadLine());
    }
    Console.Clear();
    for (int i=0; i<quant;i++)
    {
      Console.WriteLine("Digite o {0} numero da lista 2: ", i+1);
      l2[i]=int.Parse(Console.ReadLine());
    }

    for (int i=0; i<quant;i++)
    {
      if(l1[i]==l2[i])
      {
        cont++;
      }
    }
    Console.WriteLine("As listas tem {0} numeros identicos nas mesmas posicoes", cont);
    
  }
}
*/
/*
using System; 

public class Program {

  public static void Main(string[] args) {
    int menu, quant;

    Console.WriteLine("Digite a quantidade de numeros que deseja: ");
    quant=int.Parse(Console.ReadLine());
    Console.Clear();

    int[] vetor = new int[quant];

    for(int i = 0; i<quant;i++)
    {
      Console.WriteLine("Digite o {0} valor: ", i+1);
      vetor[i]=int.Parse(Console.ReadLine());
    }
    
    do{
      Console.Clear();
      Console.WriteLine("Menu:\n(1)\tListar vetor\n(2)\tMostrar pares\n(3)\tMostrar impares\n(4)\tExibir a quantidade de numeros pares existem nas posicoes impares do vetor\n(5)\tExibir a quantidade de numeros impares existem nas posicoes pares do vetor\n(6)\tSair\n");
      menu=int.Parse(Console.ReadLine());
      switch(menu)
      {
        case 1:
        for(int i=0;i<quant;i++)
        {
          Console.WriteLine("Valor {0}: {1}",i+1,vetor[i]);
        }
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;

        case 2:
        Console.WriteLine("Pares:");
        int a =0;
        for(int i=0;i<quant;i++)
        {
          if(vetor[i]%2==0)
          {
            Console.WriteLine("Valor {0}: {1}",a+1,vetor[i]);
            a++;
          }
        }
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;

        case 3:
        Console.WriteLine("Impares:");
        int b =0;
        for(int i=0;i<quant;i++)
        {
          if(vetor[i]%2!=0)
          {
            Console.WriteLine("Valor {0}: {1}",b+1,vetor[i]);
            b++;
          }
        }
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;

        case 4:
        Console.WriteLine("Pares em posicoes impares:");
        int c =0;
        for(int i=0;i<quant;i++)
        {
          if((i%2!=0) && (vetor[i]%2==0))
          {
            Console.WriteLine("Valor {0}: {1}",c+1,vetor[i]);
            c++;
          }
        }
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;

        case 5:
        Console.WriteLine("Impares em posicoes pares:");
        int d =0;
        for(int i=0;i<quant;i++)
        {
          if((i%2==0) && (vetor[i]%2!=0))
          {
            Console.WriteLine("Valor {0}: {1}",d+1,vetor[i]);
            d++;
          }
        }
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;

        case 6:
        break;

        default:
        Console.WriteLine("\nInput invalido");
        Console.WriteLine("\nDigite algo para continuar: ");
        Console.ReadKey();
        break;
      }
      
    }while (menu !=6);
  
  }
}
*/