using System;

namespace GMC_4
{
    static class Address
    {
        public static readonly int finalProgramAddress = Program.HexToInt("4F");
        public static readonly int finalDataAddress = Program.HexToInt("5F");
        public static readonly int finalMemoryAddress = Program.HexToInt("6F");
        public static int address = Program.HexToInt("00");

        public static int get()
        {
            return address;
        }

        public static void increment()
        {
            address = (address == finalMemoryAddress) ? Program.HexToInt("00") : address + 1;
        }

        public static void decrement()
        {
            address = (address == finalMemoryAddress) ? Program.HexToInt("6F") : address - 1;
        }

        public static void set(int addr)
        {
            if (Program.HexToInt("00") <= addr && addr <= finalDataAddress)
                address = addr;
            else if (addr == Program.HexToInt("FF"))
                address = finalProgramAddress; // "FFF"(アドレスFFへジャンプ)のような場合はプログラムの最終アドレスへ移動
            else
            {
                Console.WriteLine("Out bounds " + addr);
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// アドレスがプログラムメモリの最後まで来たか判定します。
        /// </summary>
        /// <returns></returns>
        public static bool isFinal()
        {
            return address == finalProgramAddress;
        }

        public static void reset()
        {
            address = Program.HexToInt("00");
        }
    }
}
