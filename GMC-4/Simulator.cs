using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    /// <summary>
    /// シミュレータのクラス
    /// </summary>
    class Simulator
    {
        /// <summary>
        /// Form1の参照を受け付ける
        /// </summary>
        private Form1 form1;

        /// <summary>
        /// シミュレータをインスタンス化します。
        /// </summary>
        /// <param name="form">Form1の参照</param>
        public Simulator(Form1 form)
        {
            form1 = form;
        }

        /// <summary>
        /// 命令を1つ実行します。
        /// </summary>
        public void execute()
        {
            // 1ワード分とってくる
            char word = Memory.getWord(Address.get());
            char tmp;
            int value;
            Console.WriteLine("Address " + Address.get() + " -> " + word);
            try
            {
                switch (word)
                {
                    case '0':
                        Console.WriteLine("Input getting");
                        if (Buffer.Flag)
                        {
                            Register.A = Buffer.get();
                            Register.Flag = '0';
                        }
                        else
                            Register.Flag = '1';
                        break;
                    case '1':
                        Console.WriteLine("Output Register A");
                        form1.setLEDMatrix(Register.A);
                        Register.Flag = '1';
                        break;
                    case '2':
                        Console.WriteLine("Replace Register A to B");
                        tmp = Register.A;
                        Register.A = Register.B;
                        Register.B = tmp;

                        tmp = Register.Y;
                        Register.Y = Register.Z;
                        Register.Z = tmp;

                        Register.Flag = '1';
                        break;
                    case '3':
                        Console.WriteLine("Replace Register A to Y");
                        tmp = Register.A;
                        Register.A = Register.Y;
                        Register.Y = tmp;
                        Register.Flag = '1';
                        break;
                    case '4':
                        Console.WriteLine("Write value where Register A to Data Memory 0x50+0x" + Register.Y.ToString());
                        Memory.set(Register.A, Program.HexToInt("50") + Convert.ToInt32(Register.Y.ToString(), 16));
                        Register.Flag = '1';
                        break;
                    case '5':
                        Console.WriteLine("Read value where Data Memory 0x50+0x" + Register.Y.ToString() + " to Register A");
                        Register.A = Memory.getWord(Program.HexToInt("50") + Convert.ToInt32(Register.Y.ToString(), 16));
                        Register.Flag = '1';
                        break;
                    case '6':
                        Console.WriteLine("Write value Register A plus Data Memory 0x50+0x" + Register.Y.ToString() + " to Register A");
                        value = Convert.ToInt32(Register.A.ToString(), 16) + Convert.ToInt32(Memory.getWord(Program.HexToInt("50") + Convert.ToInt32(Register.Y.ToString(), 16)).ToString(), 16);
                        if (16 > value)
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
                        Console.WriteLine("Write value Data Memory 0x50+0x" + Register.Y.ToString() + " minus Register A to Register A");
                        value = Convert.ToInt32(Memory.getWord(Program.HexToInt("50") + Convert.ToInt32(Register.Y.ToString(), 16)).ToString(), 16) - Convert.ToInt32(Register.A.ToString(), 16);
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
                        Console.WriteLine("Read value next Memory to Register A");
                        Address.increment();
                        Register.A = Memory.getWord(Address.get());
                        Register.Flag = '1';
                        break;
                    case '9':
                        Console.WriteLine("Write value Register A plus next Memory to Register A");
                        Address.increment();
                        value = Convert.ToInt32(Register.A.ToString(), 16) + Convert.ToInt32(Memory.getWord(Address.get()).ToString(), 16);
                        if (16 > value)
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
                        Console.WriteLine("Read value next Memory to Register Y");
                        Address.increment();
                        Register.Y = Memory.getWord(Address.get());
                        Register.Flag = '1';
                        break;
                    case 'B':
                        Console.WriteLine("Write value Register Y plus next Memory to Register Y");
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
                        Console.WriteLine("Check Register A equal next Memory");
                        Address.increment();
                        Register.Flag = Register.A == Memory.getWord(Address.get()) ? '0' : '1';
                        break;
                    case 'D':
                        Console.WriteLine("Check Register Y equal next Memory");
                        Address.increment();
                        Register.Flag = Register.Y == Memory.getWord(Address.get()) ? '0' : '1';
                        break;
                    case 'F':
                        Console.WriteLine("Jump to Address next Memory");
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
                    case 'E':
                        Console.WriteLine("Extended instruction");
                        extendedInstruction();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }catch(NotImplementedException e)
            {
                // 未実装の処理はエラーとしてその場で終了させる
                error();
            }
            
        }

        /// <summary>
        /// 拡張命令を実行します。
        /// </summary>
        private void extendedInstruction()
        {
            // 拡張命令の内容を取得
            Address.increment();
            var instruction = Memory.getWord(Address.get());

            switch (instruction)
            {
                case '0':
                    Console.WriteLine("Turn off number LED");
                    form1.setLEDMatrix('\0');
                    break;
                case '1':
                    Console.WriteLine("Turn on binary LED potision " + Register.Y.ToString());

                    break;
            }
        }

        /// <summary>
        /// シミュレーション時にエラーが発生した場合に終了します。
        /// </summary>
        private void error()
        {
            Console.Beep(800, 1000);
            // アドレスを最終行に移動させる
            Address.set(Address.finalProgramAddress);
        }
    }
}
