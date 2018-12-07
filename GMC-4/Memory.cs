using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class Memory
    {
        private static char[] memory = new char[97];
        private static Register[] aRegister;
        private static Register[] bRegister;
        private static Register[] yRegister;
        private static Register[] zRegister;
        public static List<Label> labelList = new List<Label>();

        /// <summary>
        /// メモリをリセットします。
        /// </summary>
        public static void resetMemory()
        {
            memory = memory.Select(v => 'F').ToArray();
            memory[memory.Length - 1] = '\0';
        }

        /// <summary>
        /// メモリの中身を取得します。
        /// </summary>
        /// <returns>メモリの中身</returns>
        public static char[] getMemory()
        {
            return memory;
        }

        /// <summary>
        /// メモリに値をセットします。
        /// </summary>
        /// <param name="data">値</param>
        /// <param name="address">アドレス</param>
        public static void setMemory(char data, int address)
        {
            if (Program.IsHex(data))
            {
                memory[address] = data;
            }
        }

        public static char ARegister
        {
            get { return aRegister[0].get(); }
            set { aRegister[0].set(Program.IsHex(value) ? value : aRegister[0].get()); }
        }

        public static char A0Register
        {
            get { return aRegister[1].get(); }
            set { aRegister[1].set(Program.IsHex(value) ? value : aRegister[1].get()); }
        }

        public static char BRegister
        {
            get { return bRegister[0].get(); }
            set { bRegister[0].set(Program.IsHex(value) ? value : bRegister[0].get()); }
        }

        public static char B0Register
        {
            get { return bRegister[1].get(); }
            set { bRegister[1].set(Program.IsHex(value) ? value : bRegister[1].get()); }
        }

        public static char YRegister
        {
            get { return yRegister[0].get(); }
            set { yRegister[0].set(Program.IsHex(value) ? value : yRegister[0].get()); }
        }

        public static char Y0Register
        {
            get { return yRegister[1].get(); }
            set { yRegister[1].set(Program.IsHex(value) ? value : yRegister[1].get()); }
        }

        public static char ZRegister
        {
            get { return zRegister[0].get(); }
            set { zRegister[0].set(Program.IsHex(value) ? value : zRegister[0].get()); }
        }

        public static char Z0Register
        {
            get { return zRegister[1].get(); }
            set { zRegister[1].set(Program.IsHex(value) ? value : zRegister[1].get()); }
        }

        public static void resetRegister()
        {
            aRegister = aRegister.Select(reg => reg = new Register()).ToArray();
            bRegister = bRegister.Select(reg => reg = new Register()).ToArray();
            yRegister = yRegister.Select(reg => reg = new Register()).ToArray();
            zRegister = zRegister.Select(reg => reg = new Register()).ToArray();
        }
    }
}
