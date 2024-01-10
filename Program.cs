using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public void SumAverageColElements(int[,] arr, int rdj, int rdi)
        {
            int sumcol = 0;
            for (int j = 0; j <= rdj; j++)
            {
                
                for (int i = 0; i <= rdi; i++)
                {
                    sumcol += arr[i, j];
                    //Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("Sum of col" +(j+1) + " is " + sumcol);
                double colAverage = (double)sumcol / (rdi + 1);
                Console.WriteLine("Average of col" + (j + 1) + " is " + colAverage);
                Console.WriteLine();
            }
            
        }

        public void SumAverageRowElements(int[,] arr, int rdj, int rdi)
        {
            int sumrow = 0;
            for (int i = 0; i <= rdi; i++)
            {
                for (int j = 0; j <= rdj; j++)
                {
                    sumrow += arr[i, j];
                    //Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("Sum of row" + (i + 1) + " is " + sumrow);
                double rowAverage = (double)sumrow / (rdj + 1);
                Console.WriteLine("Average of row" + (i + 1) + " is " + rowAverage);
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Program pg = new Program();

            int[,] arr = new int[10, 10];
            int[,] myarr = new int[10, 10];
            int rdi = random.Next(3, 9);
            int rdj = 0;

            for (int i = 0; i <= rdi; i++)
            {
                rdj = random.Next(3, 9);
                for (int j = 0; j <= rdj; j++)
                {
                    myarr[i, j] = arr[i, j] = random.Next(10, 100);
                }
            }

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Non-zero elements of myarr:");
            for (int i = 0; i <= rdi; i++)
            {
                for (int j = 0; j <= rdj; j++)
                {
                    if (myarr[i, j] != 0)
                    {
                        Console.Write(myarr[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Number of Columns: " + (rdj + 1));
            Console.WriteLine("Number of Rows: " + (rdi + 1));

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Columns");
            Console.WriteLine("--------------------------------------------------------------------");

            pg.SumAverageColElements(myarr, rdj, rdi);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Rows");
            Console.WriteLine("--------------------------------------------------------------------");
            pg.SumAverageRowElements(myarr, rdj, rdi);

            Console.WriteLine("--------------------------------------------------------------------");


        }
    }
}
