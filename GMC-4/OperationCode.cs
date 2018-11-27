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
            {"JUMP", 'E' }
        };

        public static int addOperationCode(string operationCode)
        {
            return operationCodeToAddress[operationCode];
        }

        public static void compileOperationCode(string operationCode, string operand)
        {
            var code = operationCodeToInstructionCode[operationCode];
            Program.setMemory(code, Address.getAddress());
            Address.incrementAddress();
            if ('8' <= code && code <= 'F')
            {
                Program.setMemory(operand[0], Address.getAddress());
                Address.incrementAddress();
            }
            if(code == 'F')
            {
                Program.setMemory(operand[1], Address.getAddress());
                Address.incrementAddress();
            }
        }
    }
}
