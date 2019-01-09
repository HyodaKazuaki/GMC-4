using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        /// 16進数の文字列を10進数の数値に変換します。
        /// </summary>
        /// <param name="hex">16進数の文字列</param>
        /// <returns>10進数の数値</returns>
        public static int HexToInt(string hex)
        {
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        /// <summary>
        /// 各記憶領域をリセットします。
        /// </summary>
        public static void reset()
        {
            Memory.reset();
            Register.reset();
            Buffer.reset();
            Address.reset();
        }
    }
}
