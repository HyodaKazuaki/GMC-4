using System;
using System.Collections.Generic;
using System.Linq;

namespace GMC_4
{
    static class OperationCode
    {
        // データメモリのアドレス
        private static int dataMemoryAddress = Program.HexToInt("50");

        /// <summary>
        /// オペコードを機械語に変換するときに必要なメモリアドレス数の辞書
        /// </summary>
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

        /// <summary>
        /// 各命令に必要な引数の数の辞書
        /// </summary>
        private static Dictionary<string, int> assemblerArgumentOfNumber = new Dictionary<string, int>()
        {
            {"KA", 0 },
            {"AO", 0 },
            {"CH", 0 },
            {"CY", 0 },
            {"AM", 0 },
            {"MA", 0 },
            {"M+", 0 },
            {"M-", 0 },
            {"TIA", 1 },
            {"AIA", 1 },
            {"TIY", 1 },
            {"AIY", 1 },
            {"CIA", 1 },
            {"CIY", 1 },
            {"JUMP", 1 },
            {"CAL", 1 },
            {"DC", 1 },
            {"RET", 0 }
        };

        /// <summary>
        /// オペコードを機械語に変換する辞書
        /// </summary>
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

        /// <summary>
        /// 拡張命令(CAL)を機械語に変換する辞書
        /// </summary>
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
            // オペランド過不足チェック
            var numberOfOperand = operand == "" ? 0 : 1;
            if (assemblerArgumentOfNumber[operationCode] > numberOfOperand)
                throw new ArgumentLackException(); // オペランドが少ない
            if (assemblerArgumentOfNumber[operationCode] < numberOfOperand)
                throw new ArgumentExcessException(); // オペランドが多い

            // 命令がない場合は飛ばす
            if (operationCode == "")
                return;
            // DC命令はオペランドをデータメモリに記憶する
            if(operationCode == "DC")
            {
                storageValueToMemory(operand.First());
                return;
            }

            // オペコードを変換
            var code = operationCodeToInstructionCode[operationCode];
            Memory.write(code);
            // RETのみアドレスジャンプを要求してくる
            if (operationCode == "RET")
            {
                Memory.write('F');
                Memory.write('F');
            }
            // オペランドが1つある
            if ('8' <= code && code <= 'D')
            {
                Memory.write(operand[0]);
            }
            // ラベルジャンプ命令
            if (code == 'F' && operationCode != "RET")
            {
                Console.WriteLine("Search label " + operand);
                var address = Memory.labelList.Where(x => x.Name() == operand).Select(x => x.Address()).First();
                Memory.write(address[0]);
                Memory.write(address[1]);
            }
            // 拡張命令の場合はオペランドを命令に変換する
            if (code == 'E')
            {
                var exCode = extendOperationCodeToInstructionCode[operand];
                Memory.write(exCode);
            }

        }

        /// <summary>
        /// データメモリ領域に値を記憶させます。
        /// </summary>
        /// <param name="value">値</param>
        private static void storageValueToMemory(char value)
        {
            // データメモリのアドレスをアドレスとしてセット(バッファオーバーフローしたときの処理があるため)
            Address.set(dataMemoryAddress);
            Memory.write(value);
            dataMemoryAddress = Address.get();
        }

        /// <summary>
        /// データメモリ領域のアドレスをリセットします。
        /// </summary>
        public static void resetDataMemoryAddress()
        {
            dataMemoryAddress = Program.HexToInt("50");
        }
    }
}
