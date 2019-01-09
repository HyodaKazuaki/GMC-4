using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GMC_4
{
    public partial class Form1 : Form
    {
        private Simulator simulator;
        public Form1()
        {
            InitializeComponent();

            // シミュレータクラスでForm1にアクセスする必要があるため参照を渡す
            // また、Simulatorクラスをインスタンス化する
            simulator = new Simulator(this);

            // メモリ表示とLEDマトリクスをリセット
            setMemoryText();
            setLEDMatrix(Memory.getWord(Address.get()));
        }

        private void buttonINCR_Click(object sender, EventArgs e)
        {
            // バッファにデータが入っている=いずれかのボタンが押されたときのみメモリに値をセットする
            if(Buffer.Flag) Memory.set(Buffer.get(), Address.get());
            Address.increment();
            // アドレス表示LEDとメモリ表示、LEDマトリクスをセットする
            setBinaryLED();
            setMemoryText();
            setLEDMatrix(Memory.get()[Address.get()]);
            // バッファをリセット
            Buffer.reset();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            // どのボタンが押されたか調べる
            var button = (Button)sender;
            var buttonNumberString = button.Name.Replace("button", "");
            var buttonNumber = char.Parse(buttonNumberString);
            // 押されたボタンのLEDマトリクスを光らせる
            setLEDMatrix(buttonNumber);
            // バッファにボタンの値を与える
            Buffer.set(buttonNumber);
        }

        private void setBinaryLED()
        {
            // AND演算で対応するLEDを光らせる
            binaryLED0.BackColor = ((Address.get() & 0b0000001) == 0b0000001) ? Color.Red : Color.Black;
            binaryLED1.BackColor = ((Address.get() & 0b0000010) == 0b0000010) ? Color.Red : Color.Black;
            binaryLED2.BackColor = ((Address.get() & 0b0000100) == 0b0000100) ? Color.Red : Color.Black;
            binaryLED3.BackColor = ((Address.get() & 0b0001000) == 0b0001000) ? Color.Red : Color.Black;
            binaryLED4.BackColor = ((Address.get() & 0b0010000) == 0b0010000) ? Color.Red : Color.Black;
            binaryLED5.BackColor = ((Address.get() & 0b0100000) == 0b0100000) ? Color.Red : Color.Black;
            binaryLED6.BackColor = ((Address.get() & 0b1000000) == 0b1000000) ? Color.Red : Color.Black;
        }

        public void setLEDMatrix(char character)
        {
            // 対応する値のみ光らせる
            SegmentLED0.BackColor = new Char[] { '0', '2', '3', '5', '6', '7', '8', '9', 'A', 'C', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED1.BackColor = new Char[] { '0', '1', '2', '3', '4', '7', '8', '9', 'A', 'D' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED2.BackColor = new Char[] { '0', '1', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'D' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED3.BackColor = new Char[] { '0', '2', '3', '5', '6', '8', 'B', 'C', 'D', 'E' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED4.BackColor = new Char[] { '0', '2', '6', '8', 'A', 'B', 'C', 'D', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED5.BackColor = new Char[] { '0', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED6.BackColor = new Char[] { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'D', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
        }

        string FileName = "";

        private void openFileOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // ファイル名を記憶しておく
            FileName = openFileDialog1.FileName;

            // プログラムを読み出す
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
            {
                sourceCodeBox.Text = sr.ReadToEnd();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ファイル名がなければダイアログを開く
            if (FileName == "")
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                else
                    FileName = saveFileDialog1.FileName;
            // ファイルにプログラムを書き込む
            var file = new File();
            file.Write(sourceCodeBox.Text);
        }

        void setMemoryText()
        {
            // メモリを読み出して表示する
            var memory = Memory.get();
            memoryText.Text = new string(memory);
        }

        private void assembleButton_Click(object sender, EventArgs e)
        {
            // すでに記憶された命令をすべてリセットする
            Program.reset();
            // コンパイルを行う
            var compiler = new Compiler(sourceCodeBox.Text);
            compiler.Compile();

            // 結果のメモリを表示する
            setMemoryText();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // シミュレータを起動する
            startSimulator();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Address " + Address.get() + " Processing");
            // プログラムの終了チェック
            if (Address.isFinal()) stopSimulator();

            // シミュレーションを1つ行う
            simulator.execute();

            // メモリアドレスを進める
            Address.increment();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // シミュレータを停止する
            stopSimulator();
        }

        /// <summary>
        /// シミュレータを起動します。
        /// </summary>
        public void startSimulator()
        {
            Console.WriteLine("Start Simulator");
            Console.WriteLine(Memory.get());
            // アドレスをスタートへ
            Address.reset();
            // バッファのリセット
            Buffer.reset();
            // クロックタイマーを起動する
            timer1.Start();
        }

        /// <summary>
        /// シミュレータを停止します。
        /// </summary>
        public void stopSimulator()
        {
            // クロックタイマーを停止する
            timer1.Stop();
            Console.WriteLine("Stop Simulator");
        }

        private void addressSetButton_Click(object sender, EventArgs e)
        {
            // アドレスを移動する
            Address.set(Buffer.getAsAddress());
            // 移動先アドレスをLED表示する
            setBinaryLED();
            // 移動先のメモリの中身を表示する
            setLEDMatrix(Memory.getWord(Address.get()));
        }

        private void memoryResetButton_Click(object sender, EventArgs e)
        {
            Program.reset();
            setMemoryText();
            setBinaryLED();
            setLEDMatrix(Memory.getWord(Address.get()));
            resetClockSpeed(); // クロックスピードもリセットする
        }
        
        private void clockSpeedSetButton_Click(object sender, EventArgs e)
        {
            // Hzをmsに変換する
            var speed = 1.0 / (double)clockSpeed.Value * 1000.0;
            timer1.Interval = (int)speed;
        }

        private void resetClockSpeed()
        {
            timer1.Interval = 100;
        }
    }
}
