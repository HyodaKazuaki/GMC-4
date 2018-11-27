using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMC_4
{
    static class Program
    {
        private static char[] memory = new char[97];
        public static List<Label> labelList = new List<Label>();

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            memory = (new char[97]).Select(v => 'F').ToArray();
            memory[memory.Length - 1] = '\0';
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static char[] getMemory()
        {
            return memory;
        }

        public static void setMemory(char data, int address)
        {
            if(data >= '0' && data <= 'F')
            {
                memory[address] = data;
            }
        }
    }
}
