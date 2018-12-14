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
        public Form1()
        {
            InitializeComponent();

            Simulator.form1 = this;

            setMemoryText();
        }

        private void buttonINCR_Click(object sender, EventArgs e)
        {
            if(Buffer.Flag) Memory.set(Buffer.get(), Address.get());
            Address.increment();
            setBinaryLED();
            setMemoryText();
            setLEDMatrix(Memory.get()[Address.get()]);
            Buffer.reset();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonNumberString = button.Name.Replace("button", "");
            var buttonNumber = char.Parse(buttonNumberString);
            setLEDMatrix(buttonNumber);
            Buffer.set(buttonNumber);
        }

        private void setBinaryLED()
        {
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
            SegmentLED0.BackColor = new Char[] { '0', '2', '3', '5', '6', '7', '8', '9', 'A', 'C', 'E', 'F' }.Any(c => c == character) ? Color.Red : Color.Black;
            SegmentLED1.BackColor = new Char[] { '0', '1', '2', '3', '4', '7', '8', '9', 'A', 'C',　'D' }.Any(c => c == character) ? Color.Red : Color.Black;
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

            FileName = openFileDialog1.FileName;

            using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
            {
                sourceCodeBox.Text = sr.ReadToEnd();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == "")
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                else
                    FileName = saveFileDialog1.FileName;
            var file = new File();
            file.Write(sourceCodeBox.Text);
        }

        void setMemoryText()
        {
            var memory = Memory.get();
            memoryText.Text = new string(memory);
        }

        private void assembleButton_Click(object sender, EventArgs e)
        {
            Program.reset();
            var compiler = new Compiler(sourceCodeBox.Text);
            compiler.Compile();

            setMemoryText();
        }

        int r_address;
        private void runButton_Click(object sender, EventArgs e)
        {
            r_address = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // バッファのリセット
            Buffer.reset();
            // アドレスをスタートへ
            Address.set(0);
            Simulator.execute();

            Address.increment();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void addressSetButton_Click(object sender, EventArgs e)
        {
            Address.set(Buffer.getAsAddress());
        }
    }
}
