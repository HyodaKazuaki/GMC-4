using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GMC_4
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            reset();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// 文字が16進数か判定します。
        /// </summary>
        /// <param name="character">判定したい文字</param>
        /// <returns>判定結果</returns>
        public static bool IsHex(char character)
        {
            return Regex.IsMatch(character.ToString(), "[0-9a-fA-F]");
        }

        /// <summary>
        /// 各記憶領域をリセットします。
        /// </summary>
        public static void reset()
        {
            Memory.reset();
            Register.reset();
            Buffer.reset();
        }
    }
}
