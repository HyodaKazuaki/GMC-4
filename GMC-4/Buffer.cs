using System;
using System.Linq;

namespace GMC_4
{
    /// <summary>
    /// 2ワード分記憶するバッファのクラス
    /// </summary>
    static class Buffer
    {
        private static Word[] buffer;

        public static bool Flag { get; private set; } = false;

        /// <summary>
        /// バッファをリセットします。
        /// </summary>
        public static void reset()
        {
            buffer = Enumerable.Repeat(new Word(), 2).ToArray();
            Flag = false;
        }

        /// <summary>
        /// バッファに値をセットします
        /// </summary>
        /// <param name="value">16進数の値</param>
        public static void set(char value)
        {
            Flag = true;
            shift();
            buffer[0].set(value);
        }

        /// <summary>
        /// バッファの値を1つだけ取得します
        /// </summary>
        /// <returns>16進数の値</returns>
        public static char get()
        {
            return buffer[0].get();
        }

        /// <summary>
        /// バッファをアドレスとして返します
        /// </summary>
        /// <returns>アドレス番地</returns>
        public static byte getAsAddress()
        {
            string address = buffer[1].get().ToString() + buffer[0].get().ToString();
            Console.WriteLine("Move to address " + address);
            return Convert.ToByte(address, 16);
        }

        /// <summary>
        /// バッファをシフトします
        /// </summary>
        private static void shift()
        {
            buffer[1] = new Word(buffer[0].get());
        }
    }
}
