using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("enter hte number of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            increasingtriangle(rows);
            Console.WriteLine();

            decreasingtriangle(rows);
            Console.WriteLine();

            lefttriangle(rows);
            Console.WriteLine();

            Ldecreasintriangle(rows);
            Console.WriteLine();

            Pyramid(rows);
            Console.WriteLine();

            diamond(rows);
            Console.WriteLine();


            Console.ReadLine();

        }
        public static void diamond(int row)
        {
           for (int i = 1; i < row; i++)
            {
                for (int j = i; j <=row; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <i; k++)
                {
                    Console.Write("* ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int x = 1; x <=row; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("  ");
                }
                for(int z=x;z<row;z++)
                {
                    Console.Write("* ");
                }
                for (int a = x; a <=row; a++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Pyramid(int row)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=i;j<row;j++)
                {
                    Console.Write("  ");
                }
                for(int k=0;k<i;k++)
                {
                    Console.Write("* ");
                }
                for(int l=0;l<=i;l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Ldecreasintriangle(int row)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("  ");
                }
                for(int k=i;k<row;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void lefttriangle(int row)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=i;j<row;j++)
                {
                    Console.Write("  ");
                }
                for(int k=0;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void decreasingtriangle(int row)
        {
            for(int i=0;i<row;i++)
            {
                //for(int j=row;j>i;j--)
                for(int j=i;j<row;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void increasingtriangle(int row)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
