using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Compiler
    {
        private string[] sourceCode;
        private char[] del = { ' ', '\t' };
        private int startLine = 0;
        private int labelAddress = 0;

        public Compiler(string source)
        {
            sourceCode = source.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Compile()
        {
            getStartLine();
            addLabel();
            compileOperation();
        }

        /// <summary>
        /// スタートラインを探します。
        /// </summary>
        private void getStartLine()
        {
            foreach (var line in sourceCode.Select((value, index) => new { value, index }))
            {
                string[] term = line.value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                if (term[0] == "START" && line.value.IndexOf(term[0]) != 0)
                {
                    startLine = line.index;
                    break;
                }
            }
        }

        /// <summary>
        /// ラベルを追加します。
        /// </summary>
        private void addLabel()
        {
            string operationCode = "";
            foreach (var line in sourceCode.Select((value, index) => new { value, index }))
            {
                string[] term = line.value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                if (line.value.IndexOf(term[0]) == 0)
                {
                    // ラベル追加
                    Program.labelList.Add(new Label(term[0], labelAddress));
                    // オペコードは第二引数部
                    operationCode = term[1];
                }
                else if (term[0] == "END" && line.value.IndexOf(term[0]) != 0)
                {
                    // 終了
                    break;
                }
                else
                {
                    // ラベルなし、オペコードは第一引数部
                    operationCode = term[0];
                }

                // ラベルアドレスをオペコード分ずらす
                labelAddress += OperationCode.addOperationCode(operationCode);
            }
        }

        /// <summary>
        /// オペレーションコードからコンパイルを行いメモリに書き込みます。
        /// </summary>
        private void compileOperation()
        {
            string operationCode = "";
            string operand = "";
            Address.setAddress(0);

            for(int i = startLine; i < sourceCode.Length; i++)
            {
                var line = sourceCode[i];
                string[] term = line.Split(del, StringSplitOptions.RemoveEmptyEntries);
                
                if (line.IndexOf(term[0]) == 0)
                {
                    // ラベル付き
                    operationCode = term[1];
                    if (term.Length >= 3)
                        // オペランド付き
                        operand = term[2];
                }
                else if (term[0] == "END" && line.IndexOf(term[0]) != 0)
                {
                    // コンパイル終了
                    break;
                }
                else
                {
                    // ラベルなし
                    operationCode = term[0];
                    if (term.Length >= 2)
                        // オペランド付き
                        operand = term[1];
                }

                OperationCode.compileOperationCode(operationCode, operand);
            }

        }
    }
}
