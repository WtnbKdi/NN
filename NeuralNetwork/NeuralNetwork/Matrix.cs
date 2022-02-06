using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    internal static class Matrix
    {
        public static double[] Mul(double[,] lMat, double[] rMat, int sizeX, int sizeY)
        {
            double[] resMat = new double[sizeY]; // 結果行列
            for (int y = 0; y < sizeY; y++)
                for (int x = 0; x < sizeX; x++)
                    resMat[y] += lMat[y, x] * rMat[x];
            return resMat;
        }

        // 重みの計算に使う
        public static double[,] Mul(double[] lMat, double[] rMat, double[,] dstMat, double learnRate)
        {
            for(int y = 0; y < rMat.Length; y++)
                for (int x = 0; x < lMat.Length; x++)
                    dstMat[x, y] += lMat[x] * rMat[y] * learnRate;
            return dstMat;
        }

        public static double[] Mul(double[] lMat, double[] rMat)
        {
            if (lMat.Length != rMat.Length) 
                throw new Exception("二つの行列のサイズが異なります");
            double[] res = new double[lMat.Length];
            for (int x = 0; x < lMat.Length; x++)
                res[x] += lMat[x] * rMat[x];
            return res;
        }

        public static double[] Sub1Num(double[] mat)
        {
            double[] resultMat = new double[mat.Length];
            for(int i = 0; i < mat.Length; i++)
                resultMat[i] = 1.00 - mat[i];
            return resultMat;
        }

        // 誤差の計算に使う
        public static double[] OutError(double[] lMat, double[] rMat)
        {
            double[] resultMat = new double[lMat.Length];
            for (int i = 0; i < lMat.Length; i++)
                resultMat[i] = rMat[i] - lMat[i];
            return resultMat;
        }

        // 転置行列
        public static double[,] Transpose(double[,] mat, int sizeX, int sizeY)
        {
            double[,] resultMat = new double[sizeX, sizeY];
            for(int y = 0; y < sizeY; y++)
                for (int x = 0; x < sizeX; x++)
                    resultMat[x, y] = mat[y, x];
            return resultMat;
        }

        // 転置行列
        public static double[] Transpose(double[] mat)
        {
            double[] resultMat = new double[mat.Length];
            for (int i = 0; i < mat.Length; i++)
                resultMat[i] = mat[mat.Length - 1 - i];
            return resultMat;
        }

        // 加算 行列
        public static double[,] Add(double[,] lMat, double[,] rMat, int sizeX, int sizeY)
        {
            double[,] resultMat = new double[sizeX, sizeY];
            for (int y = 0; y < sizeX; y++)
                for (int x = 0; x < sizeY; x++)
                    lMat[y,x] += rMat[y,x];
            return resultMat;
        }
    }
}
