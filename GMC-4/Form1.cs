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

            setMemoryText();
        }

        private void buttonINCR_Click(object sender, EventArgs e)
        {
            Address.incrementAddress();
            setBinaryLED(Address.getAddress());
        }

        private void setBinaryLED(byte address)
        {
            binaryLED0.BackColor = ((address & 0b0000001) == 0b0000001) ? Color.Red : Color.Black;
            binaryLED1.BackColor = ((address & 0b0000010) == 0b0000010) ? Color.Red : Color.Black;
            binaryLED2.BackColor = ((address & 0b0000100) == 0b0000100) ? Color.Red : Color.Black;
            binaryLED3.BackColor = ((address & 0b0001000) == 0b0001000) ? Color.Red : Color.Black;
            binaryLED4.BackColor = ((address & 0b0010000) == 0b0010000) ? Color.Red : Color.Black;
            binaryLED5.BackColor = ((address & 0b0100000) == 0b0100000) ? Color.Red : Color.Black;
            binaryLED6.BackColor = ((address & 0b1000000) == 0b1000000) ? Color.Red : Color.Black;
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
            var memory = Program.getMemory();
            memoryText.Text = new string(memory);
        }

        private void assembleButton_Click(object sender, EventArgs e)
        {
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
            var memory = Program.getMemory();
            if(memory[r_address] == '0')
            {
                // KA
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
