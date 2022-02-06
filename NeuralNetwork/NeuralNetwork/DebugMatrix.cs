using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    internal static class DebugMatrix
    {
        // 2次元 行列内表示
        public static void OutputMatrix(double[,] mat, int sizeX, int sizeY)
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    Debug.Write(mat[y, x] + " ");
                }
                Debug.WriteLine(" ");
            }
        }

        // 1次元 行列内表示
        public static void OutputMatrix(double[] mat)
        {
            foreach (var index in mat) Debug.Write(index + " ");
            Debug.WriteLine(" ");
        }
    }
}
