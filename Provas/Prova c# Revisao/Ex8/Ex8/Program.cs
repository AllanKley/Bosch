using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 4, M = 4, O = 0, P = 0,k = 0;

            int[] A = new int[M];
            int[] B = new int[N];
            

            bool igual = false;

            A[0] = 1;
            A[1] = 2;
            A[2] = 3;
            A[3] = 4;

            B[0] = 1;
            B[1] = 3;
            B[2] = 5;
            B[3] = 4;

            //------------------------------------------------------------- INTERSECÇÃO

            for (int i = 0;i < M; i++) 
            {
                for(int j = 0; j < N; j++)
                {
                    if (A[i] == B[j])
                    {
                        O++;
                    }
                }
            }

            int[] C = new int[O]; 

        
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i] == B[j])
                    {
                        C[k] = A[i];
                        k++;
                    }
                }
            }

            //------------------------------------------------------------- UNIAO


            igual = false; 
            P = M;
            for(int i = 0; i < N; i++)
            {
                igual = false;
                for( int j = 0; j < M; j++)
                {
                    if(B[i] == A[j])
                    {
                        igual = true;
                    }
                }
                if (!igual)
                {
                    P++;
                }
            }
            igual = false;


            int[] D = new int[P]; 

            for (int i = 0; i < M; i++) 
            {
                D[i] = A[i];
            }

            k = M;

            for (int i = 0; i < N; i++)
            {
                igual = false;
                for(int j = 0; j < D.Length; j++)
                {
                    if (D[j] == B[i])
                    {
                        igual = true;
                    }
                }

                if (!igual)
                {
                    D[k] = B[i];
                    k++;
                }    
            }
            Array.Sort(D);

            //------------------------------------------------------------- PRINT

            Console.Write("A: ");
            foreach (int i in A) // PRINT A
            {
                Console.Write(i);
            }
            Console.Write("\nB: ");

            foreach (int i in B) // PRINT B
            {
                Console.Write(i);
            }
            Console.Write("\nC: ");

            foreach (int i in C) // PRINT C
            {
                Console.Write(i);
            }
            Console.Write("\nD: ");

            foreach (int i in D) // PRINT D
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");

        }
    }
}
