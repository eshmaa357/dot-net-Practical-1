// Write a C# program to perform matrix multiplication using array input. 

using System;

namespace Ishma_dot_net_practical_1
{
    class IshmaLab1Qn11
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for Matrix A:");
            int rowsA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for Matrix A (and rows for Matrix B):");
            int colsA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for Matrix B:");
            int colsB = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[colsA, colsB];
            int[,] resultMatrix = new int[rowsA, colsB];

            Console.WriteLine("Enter the elements of Matrix A:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the elements of Matrix B:");
            for (int i = 0; i < colsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Resultant Matrix after Multiplication:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}



    
