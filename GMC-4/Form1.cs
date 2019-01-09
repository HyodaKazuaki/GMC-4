using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            playButtonSound();
            // バッファにデータが入っている=いずれかのボタンが押されたときのみメモリに値をセットする
            if (Buffer.Flag) Memory.set(Buffer.get(), Address.get());
            Address.increment();
            // アドレス表示LEDとメモリ表示、LEDマトリクスをセットする
            setBinaryLED(Address.get());
            setMemoryText();
            setLEDMatrix(Memory.get()[Address.get()]);
            // バッファをリセット
            Buffer.reset();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            playButtonSound();
            // どのボタンが押されたか調べる
            var button = (Button)sender;
            var buttonNumberString = button.Name.Replace("button", "");
            var buttonNumber = char.Parse(buttonNumberString);
            // 押されたボタンのLEDマトリクスを光らせる
            setLEDMatrix(buttonNumber);
            // バッファにボタンの値を与える
            Buffer.set(buttonNumber);
        }

        public void setBinaryLED(int address)
        {
            // AND演算で対応するLEDを光らせる
            binaryLED0.BackColor = ((address & 0b0000001) == 0b0000001) ? Color.Red : Color.Black;
            binaryLED1.BackColor = ((address & 0b0000010) == 0b0000010) ? Color.Red : Color.Black;
            binaryLED2.BackColor = ((address & 0b0000100) == 0b0000100) ? Color.Red : Color.Black;
            binaryLED3.BackColor = ((address & 0b0001000) == 0b0001000) ? Color.Red : Color.Black;
            binaryLED4.BackColor = ((address & 0b0010000) == 0b0010000) ? Color.Red : Color.Black;
            binaryLED5.BackColor = ((address & 0b0100000) == 0b0100000) ? Color.Red : Color.Black;
            binaryLED6.BackColor = ((address & 0b1000000) == 0b1000000) ? Color.Red : Color.Black;
        }

        /// <summary>
        /// 入力した値の通りに数字LEDを点灯します。0-F以外の値であればLEDを消灯します。
        /// </summary>
        /// <param name="character">値</param>
        public void setLEDMatrix(char character)
        {
            // 対応する値のみ光らせる
            SegmentLED0.BackColor = new char[] { '0', '2', '3', '5', '6', '7', '8', '9', 'A', 'C', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED1.BackColor = new char[] { '0', '1', '2', '3', '4', '7', '8', '9', 'A', 'D' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED2.BackColor = new char[] { '0', '1', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'D' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED3.BackColor = new char[] { '0', '2', '3', '5', '6', '8', 'B', 'C', 'D', 'E' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED4.BackColor = new char[] { '0', '2', '6', '8', 'A', 'B', 'C', 'D', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED5.BackColor = new char[] { '0', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED6.BackColor = new char[] { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'D', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
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
            playButtonSound();
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
            playButtonSound();
            // ステップ実行フラグをリセットしておく
            didStepRun = false;
            // シミュレータを起動する
            startSimulator();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // シミュレーションを行う
            runSimulation();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            playButtonSound();
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
            resetAddressAndBuffer();
            // クロックタイマーを起動する
            timer1.Start();
        }

        private void runSimulation()
        {
            Console.WriteLine("Address " + Address.get() + " Processing");
            // プログラムの終了チェック
            if (Address.isFinal()) stopSimulator();

            // シミュレーションを1つ行う
            simulator.execute();

            // メモリアドレスを進める
            Address.increment();
        }

        /// <summary>
        /// シミュレータを停止します。
        /// </summary>
        public void stopSimulator()
        {
            // クロック実行ならクロックタイマーを停止する
            if(!didStepRun) timer1.Stop();
            // ステップ実行ならステップ実行フラグをもとに戻す
            else didStepRun = false;

            Console.WriteLine("Stop Simulator");
        }

        private void addressSetButton_Click(object sender, EventArgs e)
        {
            playButtonSound();
            try
            {
                // アドレスを移動する
                Address.set(Buffer.getAsAddress());
                // 移動先アドレスをLED表示する
                setBinaryLED(Address.get());
                // 移動先のメモリの中身を表示する
                setLEDMatrix(Memory.getWord(Address.get()));
            }
            catch (ArgumentOutOfRangeException er)
            {
                Sound.error();
            }
        }

        private void memoryResetButton_Click(object sender, EventArgs e)
        {
            playButtonSound();
            stopSimulator();
            Program.reset();
            setMemoryText();
            setBinaryLED(Address.get());
            setLEDMatrix(Memory.getWord(Address.get()));
            resetClockSpeed(); // クロックスピードもリセットする
        }
        
        private void clockSpeedSetButton_Click(object sender, EventArgs e)
        {
            playButtonSound();
            // Hzをmsに変換する
            var speed = 1.0 / (double)clockSpeed.Value * 1000.0;
            timer1.Interval = (int)speed;
        }

        private void resetClockSpeed()
        {
            timer1.Interval = 100;
            clockSpeed.Value = 1000 / 100;
        }

        private bool didStepRun = false;
        private void stepRunButton_Click(object sender, EventArgs e)
        {
            playButtonSound();
            // 初回実行ならシミュレータを一旦停止して、アドレスとバッファのリセットを行う
            if (!didStepRun)
            {
                stopSimulator();
                resetAddressAndBuffer();
            }
            // ステップ実行フラグを有効化する
            didStepRun = true;

            // シミュレーションする
            runSimulation();
        }

        /// <summary>
        /// アドレスとバッファをリセットします。
        /// </summary>
        private void resetAddressAndBuffer()
        {
            // アドレスをスタートへ
            Address.reset();
            // バッファのリセット
            Buffer.reset();
        }

        /// <summary>
        /// ボタンを押したときの音を再生します。
        /// </summary>
        private void playButtonSound()
        {
            Console.Beep(900, 50);
        }
    }
}
