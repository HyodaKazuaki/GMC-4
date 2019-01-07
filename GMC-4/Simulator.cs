using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Simulator
    {
        public static Form1 form1
        {
            set; private get;
        }

        /// <summary>
        /// 命令を1つ実行します。
        /// </summary>
        public static void execute()
        {
            char word = Memory.getWord(Address.get());
            char tmp;
            int value;
            Console.WriteLine("Address " + Address.get() + " -> " + word);
            switch (word)
            {
                case '0':
                    Console.WriteLine("Input getting...");
                    if (Buffer.Flag)
                    {
                        Register.A = Buffer.get();
                        Register.Flag = '0';
                    }
                    else
                        Register.Flag = '1';
                    break;
                case '1':
                    form1.setLEDMatrix(Register.A);
                    Register.Flag = '1';
                    break;
                case '2':
                    tmp = Register.A;
                    Register.A = Register.B;
                    Register.B = tmp;

                    tmp = Register.Y;
                    Register.Y = Register.Z;
                    Register.Z = tmp;

                    Register.Flag = '1';
                    break;
                case '3':
                    tmp = Register.A;
                    Register.A = Register.Y;
                    Register.Y = tmp;
                    Register.Flag = '1';
                    break;
                case '4':
                    Memory.set(Register.A, Program.HexToInt("50") + Convert.ToInt32(Register.Y.ToString(), 16));
                    Register.Flag = '1';
                    break;
                case '5':
                    Register.A = Memory.getWord(50 + Convert.ToInt32(Register.Y.ToString(), 16));
                    Register.Flag = '1';
                    break;
                case '6':
                    value = Convert.ToInt32(Register.A.ToString(), 16) + Convert.ToInt32(Memory.getWord(50 + Convert.ToInt32(Register.Y.ToString(), 16)).ToString(), 16);
                    if(16 > value)
                    {
                        Register.Flag = '0';
                    }
                    else
                    {
                        value = value - 16;
                        Register.Flag = '1';
                    }
                    Register.A = value.ToString("X").ToCharArray()[0];
                    break;
                case '7':
                    value = Convert.ToInt32(Memory.getWord(50 + Convert.ToInt32(Register.Y.ToString(), 16)).ToString(), 16) - Convert.ToInt32(Register.A.ToString(), 16);
                    if (value > 0)
                    {
                        Register.Flag = '0';
                    }
                    else
                    {
                        value = 16 - value;
                        Register.Flag = '1';
                    }
                    Register.A = value.ToString("X").ToCharArray()[0];
                    break;
                case '8':
                    Address.increment();
                    Register.A = Memory.getWord(Address.get());
                    Register.Flag = '1';
                    break;
                case '9':
                    Address.increment();
                    value = Convert.ToInt32(Register.A.ToString(), 16) + Convert.ToInt32(Memory.getWord(Address.get()).ToString(), 16);
                    if(16 > value)
                    {
                        Register.Flag = '0';
                    }
                    else
                    {
                        value = value - 16;
                        Register.Flag = '1';
                    }
                    Register.A = value.ToString("X").ToCharArray()[0];
                    break;
                case 'A':
                    Address.increment();
                    Register.Y = Memory.getWord(Address.get());
                    Register.Flag = '1';
                    break;
                case 'B':
                    Address.increment();
                    value = Convert.ToInt32(Register.Y.ToString(), 16) + Convert.ToInt32(Memory.getWord(Address.get()).ToString(), 16);
                    if (16 > value)
                    {
                        Register.Flag = '0';
                    }
                    else
                    {
                        value = value - 16;
                        Register.Flag = '1';
                    }
                    Register.Y = value.ToString("X").ToCharArray()[0];
                    break;
                case 'C':
                    Address.increment();
                    if (Register.A == Memory.getWord(Address.get()))
                        Register.Flag = '0';
                    else
                        Register.Flag = '1';
                    break;
                case 'D':
                    Address.increment();
                    if (Register.Y == Memory.getWord(Address.get()))
                        Register.Flag = '0';
                    else
                        Register.Flag = '1';
                    break;
                case 'F':
                    Address.increment();
                    value = Convert.ToInt32(Memory.getWord(Address.get()).ToString(), 16) * 16;
                    Address.increment();
                    value += Convert.ToInt32(Memory.getWord(Address.get()).ToString(), 16);
                    if (Register.Flag == '1')
                    {
                        Address.set(Convert.ToByte(value));
                        Address.decrement(); // あとでインクリメントされるため予めデクリメントする
                    }
                    else
                        Register.Flag = '1';
                    break;
            }
        }
    }
}
