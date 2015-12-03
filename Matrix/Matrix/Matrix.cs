using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{


    class Matrix
    {
        public static int[,] CreateMatrix()
        {
            Console.WriteLine("Rows");
            int nrows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Columns");
            int ncolomns = Int32.Parse(Console.ReadLine());
            int[,] array2D = new int[nrows, ncolomns];
            Random random = new Random();

            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncolomns; j++)
                {
                    array2D[i, j] = random.Next(10, 99);
                }
            }


            return array2D;
        }

        public static int[,] RotateMatrix(int[,] array2D)
        {

            int[,] rotateArray2D = new int[array2D.GetLength(0), array2D.GetLength(1)];
            Console.WriteLine();
            Console.WriteLine("------------------Result------------------------------");


            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int i = array2D.GetLength(0) - 1; i >= 0; i--)
                {
                    rotateArray2D[i,j] = array2D[j, array2D.GetLength(0) - 1 - i];

                }
            }


            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    rotateArray2D[j, array2D.GetLength(1) - 1 - i] = array2D[i, j];

                }
            }




            return rotateArray2D;
        }

        public static void ShowMatrix(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + "  ");

                }
            }
        }
    }
}
