using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NeuralNetwork
{
    public partial class MainForm : Form
    {
        NeuralNetwork nn;
        Graphics GrT; // 教師用グラフィックス
        Graphics GrInp; // 教師用グラフィックス
        bool TMouseMoveFlg = false; // 教師用 左クリック押下中であるか
        bool InpMouseMoveFlg = false; 
        int TDrawStartPointX, TDrawStartPointY;
        int InpDrawStartPointX, InpDrawStartPointY;
        Pen tPen = new Pen(Brushes.Green);
        Pen inpPen = new Pen(Brushes.Green);
        Bitmap tPicBmp;
        Bitmap inpPicBmp;
        int Resol = 20; // 筆の太さ 1 or 5の倍数

        public MainForm()
        {
            InitializeComponent();

            // ピクチャーボックスの初期化
            tPictureBox.Image = new Bitmap(tPictureBox.Width, tPictureBox.Height);
            inpPictureBox.Image = new Bitmap(inpPictureBox.Width, inpPictureBox.Height);
            tPicBmp = new Bitmap(tPictureBox.Width, tPictureBox.Height);
            inpPicBmp = new Bitmap(inpPictureBox.Width, inpPictureBox.Height);
            GrT = Graphics.FromImage(tPictureBox.Image);
            GrInp = Graphics.FromImage(inpPictureBox.Image);
            judgeButton.Enabled = false;
        }

        // チャート初期化
        void ChartInit(ChartArea ca, Series ser)
        {
            chart.ChartAreas.Clear(); // デフォルト設定をクリア
            chart.Series.Clear();
            chart.ChartAreas.Add(ca);
            ca.AxisX.Title = "学習回数";
            ca.AxisY.Title = "精度";
            ca.AxisY.Maximum = 1.0; 
            ser.ChartType = SeriesChartType.Line; 
            ser.LegendText = " ";
           
        }

        // NN訓練開始
        void Train(Series ser, int learnNum, double[] tBuff)
        {
            double res = 0;
            for (int i = 1; i <= learnNum; i++)
            {
                Invoke(new Action(() => learnProgressBar.Value = (i / (learnNum / 100))));
                nn.Train(tBuff, new double[] { 1 });
                foreach (var index in nn.GetOut())
                {
                    Invoke(new Action( () => {
                        consoleListBox.Items.Add($"学習回数: {(int)i}, 精度: {index}");
                        ser.Points.AddXY(i, index);
                    }));

                    res = index;
                }
                Invoke(new Action( () => learnResLabel.Text = Convert.ToString(res)));
            }
        }

        // ピクチャーボックスのドットをカウント
        void CountDot(List<double> inpData, Bitmap b)
        {
            int cnt;
            for (int x = 0; x < tPictureBox.Width; x += Resol)
            {
                for (int y = 0; y < tPictureBox.Height; y += Resol)
                {
                    cnt = 0;
                    for (int xx = x; xx < Resol + x; xx++)
                        for (int yy = y; yy < Resol + y; yy++)
                            if (b.GetPixel(xx, yy).G > 0)
                                cnt++;
                    if (cnt > 0) inpData.Add(1);
                    else inpData.Add(0);
                }
            }
        }

        // 開始
        private async void learnButton_Click(object sender, EventArgs e)
        {
            consoleListBox.Items.Clear();
            Bitmap b = new Bitmap(tPictureBox.Image);
            List<double> inpData = new List<double>(); // 教師入力データ
            CountDot(inpData, b); //  教師入力データのドットカウント
            ChartArea ca = new ChartArea();
            Series ser = new Series();
            ChartInit(ca, ser); // チャート初期化
            int inputNodeSize = inpData.Count;
            int hideNodeSize = Convert.ToInt32(hiddenNumericUpDown.Value); // 隠れ層のサイズ
            int learnNum = Convert.ToInt32(learnNumNumericUpDown.Value); // 学習率

            // NN初期化
            nn = new NeuralNetwork(
                    inputNodeSize,
                    hideNodeSize,
                    1, Convert.ToDouble(learnRateTextBox.Text),
                    !wCheckBox.Checked,
                    Convert.ToDouble(wTextBox.Text
                ));
            //Train(ser, learnNum, inpData.ToArray());
            await Task.Run(() => {
                Train(ser, learnNum, inpData.ToArray());
            });
            chart.Series.Add(ser);
            judgeButton.Enabled = true;
        }

        // 判定ボタン イベント
        private void judgeButton_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(inpPictureBox.Image);
            List<double> inpData = new List<double>(); // 入力データ
            CountDot(inpData, b); // 入力データのドットを数える
            double res = nn.Run(inpData.ToArray())[0]; // 訓練開始
            double lRes = Convert.ToDouble(learnResLabel.Text);
            double err = Math.Abs(lRes - res) * 10000; // 教師データと入力されたデータの誤差
            resultLabel.Text = Convert.ToString(res); // 学習結果表示
            errorLabel.Text = "" + err; // 誤差
            //resembleLabel.Text = $"{err:F2}";  // 誤差

            if (err <= 0.003) resembleLabel.Text = "似ています";
            else resembleLabel.Text = "似ていません";
        }

        // クリックボタン押す
        private void inpPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            InpMouseMoveFlg = true;
            InpDrawStartPointX = e.X;
            InpDrawStartPointY = e.Y;
        }

        // クリックボタン離す
        private void inpPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            InpMouseMoveFlg = false;
        }

        // 最短距離を求める
        (int, int) DotRangeCalc(int w, int h, MouseEventArgs e)
        {
            int ResolHalf = Resol / 2;
            int closeX = 0, closeY = 0;
            double lowRange = double.MaxValue;
            for (int x = 0; x < w; x += Resol)
            {
                for (int y = 0; y < h; y += Resol)
                {
                    double range = Math.Sqrt(
                        (x + ResolHalf - e.X)
                        * (x + ResolHalf - e.X)
                        + (y + ResolHalf - e.Y)
                        * (y + ResolHalf - e.Y)
                        );
                    if (range < lowRange)
                    {
                        lowRange = range;
                        closeX = x;
                        closeY = y;
                    }
                }
            }

            return (closeX, closeY);
        }

        // マウス移動
        private void inpPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!InpMouseMoveFlg) return;
            // 複数あるのドットを書き込むマスの中心座標とマウス座標の距離を求めて、最もマウス座標から近いマスに書き込む
            (int x, int y) res = DotRangeCalc(inpPictureBox.Width, inpPictureBox.Height, e);
            GrInp.FillRectangle(Brushes.Green, res.x, res.y, Resol, Resol); // 四角形を書き込む
            inpPictureBox.Refresh();
        }

        private void tPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            TMouseMoveFlg = true;
            TDrawStartPointX = e.X;
            TDrawStartPointY = e.Y;
        }

        private void tPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            TMouseMoveFlg = false;
        }

        private void tPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!TMouseMoveFlg) return;
            (int x, int y) res = DotRangeCalc(inpPictureBox.Width, inpPictureBox.Height, e);
            GrT.FillRectangle(Brushes.Green, res.x, res.y, Resol, Resol);
            tPictureBox.Refresh();
        }
    }
}
