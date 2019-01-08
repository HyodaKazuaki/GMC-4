﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class OperationCode
    {
        private static int dataMemoryAddress = Program.HexToInt("50");
        private static Dictionary<string, int> operationCodeToAddress = new Dictionary<string, int>()
        {
            {"KA", 1 },
            {"AO", 1 },
            {"CH", 1 },
            {"CY", 1 },
            {"AM", 1 },
            {"MA", 1 },
            {"M+", 1 },
            {"M-", 1 },
            {"TIA", 2 },
            {"AIA", 2 },
            {"TIY", 2 },
            {"AIY", 2 },
            {"CIA", 2 },
            {"CIY", 2 },
            {"JUMP", 3 },
            {"CAL", 2 },
            {"DC", 1 },
            {"RET", 3 }
        };

        private static Dictionary<string, char> operationCodeToInstructionCode = new Dictionary<string, char>()
        {
            {"KA", '0' },
            {"AO", '1' },
            {"CH", '2' },
            {"CY", '3' },
            {"AM", '4' },
            {"MA", '5' },
            {"M+", '6' },
            {"M-", '7' },
            {"TIA", '8' },
            {"AIA", '9' },
            {"TIY", 'A' },
            {"AIY", 'B' },
            {"CIA", 'C' },
            {"CIY", 'D' },
            {"JUMP", 'F' },
            {"CAL", 'E' },
            {"RET", 'F' }
        };

        private static Dictionary<string, char> extendOperationCodeToInstructionCode = new Dictionary<string, char>()
        {
            {"RSTO", '0' },
            {"SETR", '1' },
            {"RSTR", '2' },
            {"CMPL", '4' },
            {"CHNG", '5' },
            {"SIFT", '6' },
            {"ENDS", '7' },
            {"ERRS", '8' },
            {"SHTS", '9' },
            {"LONS", 'A' },
            {"SUND", 'B' },
            {"TIMR", 'C' },
            {"DSPR", 'D' },
            {"DEM-", 'E' },
            {"DEM+", 'F' }
        };

        /// <summary>
        /// オペコードを機械語に変換します。
        /// </summary>
        /// <param name="operationCode">オペコード</param>
        /// <returns>機械語</returns>
        public static int addOperationCode(string operationCode)
        {
            return operationCodeToAddress[operationCode];
        }

        /// <summary>
        /// アセンブリコードを変換しメモリに書き込みます。
        /// </summary>
        /// <param name="operationCode">オペコード</param>
        /// <param name="operand">オペランド</param>
        public static void compileOperationCode(string operationCode, string operand)
        {
            // 命令がない場合は飛ばす
            if (operationCode == "")
                return;
            // DC命令はオペランドを記憶する
            if(operationCode == "DC")
            {
                storageValueToMemory(operand.First());
                return;
            }
            // オペコードを変換
            var code = operationCodeToInstructionCode[operationCode];
            Memory.set(code, Address.get());
            Address.increment();
            if (operationCode == "RET")
            {
                Memory.set('F', Address.get());
                Address.increment();
                Memory.set('F', Address.get());
                Address.increment();
            }
            else if ('8' <= code && code <= 'F' && code != 'E')
            {
                if (code == 'F')
                {
                    // ラベルジャンプ
                    var address = Memory.labelList.Where(x => x.Name() == operand).Select(x => x.Address()).First();
                    Memory.set(address[0], Address.get());
                    Address.increment();
                    Memory.set(address[1], Address.get());
                    Address.increment();
                }
                else
                {
                    Memory.set(operand[0], Address.get());
                    Address.increment();
                }
            }
            if(code == 'F')
            {
                Memory.set(operand[1], Address.get());
                Address.increment();
            }

            // 拡張命令の場合はオペランドを命令に変換する
            if (code == 'E')
            {
                var exCode = extendOperationCodeToInstructionCode[operand];
                Memory.set(exCode, Address.get());
                Address.increment();
            }

        }

        private static void storageValueToMemory(char value)
        {
            // データメモリのアドレスをアドレスとしてセット(バッファオーバーフローしたときの処理があるため)
            Address.set(dataMemoryAddress);
            Memory.set(value, Address.get());
            Address.increment();
            dataMemoryAddress = Address.get();
        }

        public static void resetDataMemoryAddress()
        {
            dataMemoryAddress = Program.HexToInt("50");
        }
    }
}
