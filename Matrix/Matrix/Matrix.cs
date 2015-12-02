using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{


    class Matrix
    {
        public static int[,] CreateMatrix() {
            Console.WriteLine("Rows");
            int nrows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Columns");
            int ncolomns = Int32.Parse(Console.ReadLine());
            int[,] array2D = new int[nrows,ncolomns];
            Random random = new Random();

            for (int i = 0; i < nrows; i++) {
                for (int j = 0; j < ncolomns; j++) {
                    array2D[i, j] = random.Next(10, 99);
                }
            }


            for (int i = 0; i < nrows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < ncolomns; j++)
                {
                    Console.Write(array2D[i, j]+"  " );
                    
                }
            }
            return array2D;
        }

        public static void RotateMatrix(int[,] array2D) {

            Console.WriteLine();
            Console.WriteLine("------------------Result------------------------------");
           
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                Console.WriteLine();
                for (int i = array2D.GetLength(0) -1; i >=0; i--)
                {
                    Console.Write(array2D[i, j] + "  ");

                }
            }


        }


    }
}
