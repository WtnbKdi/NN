namespace NeuralNetwork
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.learnButton = new System.Windows.Forms.Button();
            this.judgeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.consoleListBox = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hiddenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learnProgressBar = new System.Windows.Forms.ProgressBar();
            this.learnNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.learnRateTextBox = new System.Windows.Forms.TextBox();
            this.wCheckBox = new System.Windows.Forms.CheckBox();
            this.wTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tPictureBox = new System.Windows.Forms.PictureBox();
            this.inpPictureBox = new System.Windows.Forms.PictureBox();
            this.learnResLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnNumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(15, 551);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(171, 24);
            this.learnButton.TabIndex = 0;
            this.learnButton.Text = "訓練開始";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // judgeButton
            // 
            this.judgeButton.Location = new System.Drawing.Point(192, 551);
            this.judgeButton.Name = "judgeButton";
            this.judgeButton.Size = new System.Drawing.Size(171, 24);
            this.judgeButton.TabIndex = 2;
            this.judgeButton.Text = "判定";
            this.judgeButton.UseVisualStyleBackColor = true;
            this.judgeButton.Click += new System.EventHandler(this.judgeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "判定結果";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(87, 373);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(29, 12);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "教師データ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "入力データ";
            // 
            // consoleListBox
            // 
            this.consoleListBox.FormattingEnabled = true;
            this.consoleListBox.ItemHeight = 12;
            this.consoleListBox.Location = new System.Drawing.Point(15, 435);
            this.consoleListBox.Name = "consoleListBox";
            this.consoleListBox.Size = new System.Drawing.Size(398, 88);
            this.consoleListBox.TabIndex = 9;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(435, 15);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(534, 560);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "出力";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "隠れ層の数";
            // 
            // hiddenNumericUpDown
            // 
            this.hiddenNumericUpDown.Location = new System.Drawing.Point(19, 259);
            this.hiddenNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hiddenNumericUpDown.Name = "hiddenNumericUpDown";
            this.hiddenNumericUpDown.Size = new System.Drawing.Size(97, 19);
            this.hiddenNumericUpDown.TabIndex = 13;
            this.hiddenNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // learnProgressBar
            // 
            this.learnProgressBar.Location = new System.Drawing.Point(15, 529);
            this.learnProgressBar.Name = "learnProgressBar";
            this.learnProgressBar.Size = new System.Drawing.Size(399, 10);
            this.learnProgressBar.TabIndex = 14;
            // 
            // learnNumNumericUpDown
            // 
            this.learnNumNumericUpDown.Location = new System.Drawing.Point(133, 259);
            this.learnNumNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.learnNumNumericUpDown.Name = "learnNumNumericUpDown";
            this.learnNumNumericUpDown.Size = new System.Drawing.Size(97, 19);
            this.learnNumNumericUpDown.TabIndex = 16;
            this.learnNumNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "訓練回数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "学習率";
            // 
            // learnRateTextBox
            // 
            this.learnRateTextBox.Location = new System.Drawing.Point(248, 259);
            this.learnRateTextBox.Name = "learnRateTextBox";
            this.learnRateTextBox.Size = new System.Drawing.Size(97, 19);
            this.learnRateTextBox.TabIndex = 18;
            this.learnRateTextBox.Text = "0.2";
            // 
            // wCheckBox
            // 
            this.wCheckBox.AutoSize = true;
            this.wCheckBox.Checked = true;
            this.wCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wCheckBox.Location = new System.Drawing.Point(15, 284);
            this.wCheckBox.Name = "wCheckBox";
            this.wCheckBox.Size = new System.Drawing.Size(191, 16);
            this.wCheckBox.TabIndex = 19;
            this.wCheckBox.Text = "重み付け ( ☑: 固定値, ☐: 乱数 )";
            this.wCheckBox.UseVisualStyleBackColor = true;
            // 
            // wTextBox
            // 
            this.wTextBox.Location = new System.Drawing.Point(107, 306);
            this.wTextBox.Name = "wTextBox";
            this.wTextBox.Size = new System.Drawing.Size(49, 19);
            this.wTextBox.TabIndex = 20;
            this.wTextBox.Text = "-0.01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "重み固定値";
            // 
            // tPictureBox
            // 
            this.tPictureBox.BackColor = System.Drawing.Color.White;
            this.tPictureBox.Location = new System.Drawing.Point(7, 30);
            this.tPictureBox.Name = "tPictureBox";
            this.tPictureBox.Size = new System.Drawing.Size(200, 200);
            this.tPictureBox.TabIndex = 22;
            this.tPictureBox.TabStop = false;
            this.tPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tPictureBox_MouseDown);
            this.tPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tPictureBox_MouseMove);
            this.tPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tPictureBox_MouseUp);
            // 
            // inpPictureBox
            // 
            this.inpPictureBox.BackColor = System.Drawing.Color.White;
            this.inpPictureBox.Location = new System.Drawing.Point(213, 30);
            this.inpPictureBox.Name = "inpPictureBox";
            this.inpPictureBox.Size = new System.Drawing.Size(200, 200);
            this.inpPictureBox.TabIndex = 23;
            this.inpPictureBox.TabStop = false;
            this.inpPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inpPictureBox_MouseDown);
            this.inpPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inpPictureBox_MouseMove);
            this.inpPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inpPictureBox_MouseUp);
            // 
            // learnResLabel
            // 
            this.learnResLabel.AutoSize = true;
            this.learnResLabel.Location = new System.Drawing.Point(87, 343);
            this.learnResLabel.Name = "learnResLabel";
            this.learnResLabel.Size = new System.Drawing.Size(29, 12);
            this.learnResLabel.TabIndex = 25;
            this.learnResLabel.Text = "none";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "訓練結果";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(87, 401);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 12);
            this.errorLabel.TabIndex = 29;
            this.errorLabel.Text = "none";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "認識誤差";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(981, 588);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.learnResLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inpPictureBox);
            this.Controls.Add(this.tPictureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wTextBox);
            this.Controls.Add(this.wCheckBox);
            this.Controls.Add(this.learnRateTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.learnNumNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.learnProgressBar);
            this.Controls.Add(this.hiddenNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.consoleListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judgeButton);
            this.Controls.Add(this.learnButton);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ニューラルネットワーク";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnNumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button judgeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox consoleListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown hiddenNumericUpDown;
        private System.Windows.Forms.ProgressBar learnProgressBar;
        private System.Windows.Forms.NumericUpDown learnNumNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox learnRateTextBox;
        private System.Windows.Forms.CheckBox wCheckBox;
        private System.Windows.Forms.TextBox wTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox tPictureBox;
        private System.Windows.Forms.PictureBox inpPictureBox;
        private System.Windows.Forms.Label learnResLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label14;
    }
}

