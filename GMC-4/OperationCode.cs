using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class OperationCode
    {
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
            {"JUMP", 3 }
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
            {"JUMP", 'F' }
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
        /// アセンブリコードを変換しメモリに書き込みます。s
        /// </summary>
        /// <param name="operationCode">オペコード</param>
        /// <param name="operand">オペランド</param>
        public static void compileOperationCode(string operationCode, string operand)
        {
            // 命令がない場合は飛ばす
            if (operationCode == "")
                return;
            // オペコードを変換
            var code = operationCodeToInstructionCode[operationCode];
            Memory.set(code, Address.get());
            Address.increment();
            if ('8' <= code && code <= 'F')
            {
                Memory.set(operand[0], Address.get());
                Address.increment();
            }
            if(code == 'F')
            {
                Memory.set(operand[1], Address.get());
                Address.increment();
            }
        }
    }
}
