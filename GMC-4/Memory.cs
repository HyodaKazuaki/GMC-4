﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GMC_4
{
    static class Memory
    {
        private static char[] memory = new char[112];
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
        /// ラベルをリセットします。
        /// </summary>
        public static void resetLabel()
        {
            labelList = new List<Label>();
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
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// 現在のアドレス番地に値をセットします。また、アドレス番地のインクリメントを行います。
        /// </summary>
        /// <param name="data">値</param>
        public static void write(char data)
        {
            if(Program.IsHex(data))
            {
                memory[Address.get()] = data;
                Address.increment();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
