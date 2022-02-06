using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    internal class NeuralNetwork
    {
        double learnRate;      // 学習率
        double[,] ihWeight,    // 入力層と隠れ層の間の重み
                 hoWeight;     // 隠れ層と出力層の重み
        double[] hOut,         // 隠れ層の出力
                oOut,          // 出力層の出力 
                hErr,          // 隠れ層のエラー
                oErr;          // 出力層のエラー
        int inputNodeSize,     // 入力層サイズ
            hideNodeSize,      // 隠れ層サイズ
            outputNodeSize;    // 出力層サイズ
        Random rnd = new Random();

        // 2次元 行列内表示
        void OutputMatrix(double[,] mat, int sizeX, int sizeY)
        {
            for(int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    Debug.Write(mat[y,x] + " ");
                }
                Debug.WriteLine(" ");
            }
        }

        // 1次元 行列内表示
        void OutputMatrix(double[] mat)
        {
            foreach (var index in mat) Debug.Write(index + " ");
            Debug.WriteLine(" ");
        }

        // 重みにランダムな値をセット
        double[,] RandomSetMatrix(int sizeX, int sizeY)
        {
            double[,] resultMat = new double[sizeY, sizeX];
            for(int y = 0; y < sizeY; y++)
                for (int x = 0; x < sizeX; x++)
                    resultMat[y, x] = RandNum();
            return resultMat;
        }

        // 重みに定数値をセット
        double[,] ConstSetMatrix(int sizeX, int sizeY, double num)
        {
            double[,] resultMat = new double[sizeY, sizeX];
            for (int y = 0; y < sizeY; y++)
                for (int x = 0; x < sizeX; x++)
                    resultMat[y, x] = num;
            return resultMat;
        }

        // シグモイド関数を適用
        double[] SigmoidSetMatrix(double[] mat)
        {
            double[] resultMat = new double[mat.Length];
            for (int i = 0; i < mat.Length; i++)
                resultMat[i] = Sigmoid(mat[i]);
            return resultMat;
        }

        // シグモイド関数
        double Sigmoid(double n)
        {
            return 1.0 / (1.0 + Math.Exp(-n));
        }

        // ランダムな値を生成
        double RandNum()
        {
            return -((rnd.Next() % 100) + 1.0) / 100.0;
        }

        public NeuralNetwork() { }
        public NeuralNetwork(int inputNodeSize, int hideNodeSize, int outputNodeSize, double learnRate, bool rndWSet, double num = -0.5) 
        {
            this.learnRate = learnRate;

            this.ihWeight = new double[hideNodeSize, inputNodeSize];
            this.hoWeight = new double[outputNodeSize, hideNodeSize];


            if (rndWSet) 
            {
                // 重みを乱数で設定する
                this.ihWeight = RandomSetMatrix(inputNodeSize, hideNodeSize);
                this.hoWeight = RandomSetMatrix(hideNodeSize, outputNodeSize);
            }
            else
            {
                this.ihWeight = ConstSetMatrix(inputNodeSize, hideNodeSize, num);
                this.hoWeight = ConstSetMatrix(hideNodeSize, outputNodeSize, num);
            }

            this.inputNodeSize = inputNodeSize;
            this.hideNodeSize = hideNodeSize;
            this.outputNodeSize = outputNodeSize;
        }

        // 学習
        public void Train(double[] inpMatrix, double[] teacherMatrix)
        {
            int sizeX = outputNodeSize, sizeY = hideNodeSize;

            // 重みと入出力の計算
            hOut = SigmoidSetMatrix(Matrix.Mul(ihWeight, inpMatrix, inputNodeSize, hideNodeSize));
            oOut = SigmoidSetMatrix(Matrix.Mul(hoWeight, hOut, hideNodeSize, outputNodeSize));

            // BP
            oErr = Matrix.OutError(oOut, teacherMatrix);
            hErr = Matrix.Mul(Matrix.Transpose(hoWeight, sizeY, sizeX), oErr, sizeX, sizeY);

            // 勾配降下 各層の重みの調整
            hoWeight = Matrix.Mul(Matrix.Mul(Matrix.Mul(oErr, oOut), Matrix.Sub1Num(oOut)), Matrix.Transpose(hOut) , hoWeight, learnRate);
            ihWeight = Matrix.Mul(Matrix.Mul(Matrix.Mul(hErr, hOut), Matrix.Sub1Num(hOut)), Matrix.Transpose(inpMatrix), ihWeight, learnRate);
        }

        // 実行
        public double[] Run(double[] inputMatrix)
        {
            double[] hideOut = SigmoidSetMatrix(Matrix.Mul(ihWeight, inputMatrix, inputNodeSize, hideNodeSize));
            double[] outOut = SigmoidSetMatrix(Matrix.Mul(hoWeight, hideOut, hideNodeSize, outputNodeSize));
            return outOut;
        }

        // 出力層の出力を返す
        public double[] GetOut()
        {
            return oOut;
        }
    }
}
