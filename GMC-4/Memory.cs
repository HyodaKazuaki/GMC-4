using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class Memory
    {
        private static char[] memory = new char[97];
        public static List<Label> labelList = new List<Label>();

        /// <summary>
        /// メモリをリセットします。
        /// </summary>
        public static void reset()
        {
            memory = memory.Select(v => 'F').ToArray();
            memory[memory.Length - 1] = '\0';
        }

        /// <summary>
        /// メモリの中身を取得します。
        /// </summary>
        /// <returns>メモリの中身</returns>
        public static char[] get()
        {
            return memory;
        }
        
        /// <summary>
        /// 指定した番地にある値を返します。
        /// </summary>
        /// <param name="address">アドレス番地</param>
        /// <returns>16進数の値</returns>
        public static char getWord(int address)
        {
            return memory[address];
        }

        /// <summary>
        /// メモリに値をセットします。
        /// </summary>
        /// <param name="data">値</param>
        /// <param name="address">アドレス</param>
        public static void set(char data, int address)
        {
            if (Program.IsHex(data))
            {
                memory[address] = data;
            }
        }
    }
}
