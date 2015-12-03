using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = Matrix.CreateMatrix();
            Matrix.ShowMatrix(matrix);

            int[,] rotMatrix = Matrix.RotateMatrix(matrix);
            Matrix.ShowMatrix(rotMatrix);

        

            Console.ReadLine();
        }
    }
}
