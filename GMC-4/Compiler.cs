using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Compiler
    {
        private string[] sourceCode;
        private char[] del = { ' ', '\t' }; // ソースコード中から除去する文字
        private int startLine = 0;
        private int labelAddress = 0;

        /// <summary>
        /// ソースコードをコンパイルするためにソースコードを受け取ります。
        /// </summary>
        /// <param name="source">ソースコード</param>
        public Compiler(string source)
        {
            // 行ごとに分割
            sourceCode = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            // 不要なコメントを除去
            sourceCode = sourceCode.Select(code => removeComment(code)).ToArray();
        }

        /// <summary>
        /// ソースコードをコンパイルします。
        /// </summary>
        public void Compile()
        {
            // スタートラインを探し、ラベルを処理した上で機械語に変換する
            getStartLine();
            addLabel();
            compileOperation();
        }

        /// <summary>
        /// コードのコメントを除去します。
        /// </summary>
        /// <param name="code">コメントを含む1行のコード</param>
        /// <returns>コメントを取り除いた1行のコード</returns>
        private string removeComment(string code)
        {
            return code.Split(new char[] { ';' })[0];
        }

        /// <summary>
        /// スタートラインを探します。
        /// </summary>
        private void getStartLine()
        {
            foreach (var line in sourceCode.Select((value, index) => new { value, index }))
            {
                string[] term = line.value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                // STARTから始まる行をスタートラインとする
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
            for(int i = startLine + 1; i < sourceCode.Length; i++)
            {
                var value = sourceCode[i];
                string[] term = value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                if (value.IndexOf(term[0]) == 0)
                {
                    // ラベル追加
                    Memory.labelList.Add(new Label(term[0], labelAddress));
                    // オペコードは第二引数部
                    operationCode = term[1];
                }
                else if (term[0] == "END" && value.IndexOf(term[0]) != 0)
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
            Address.reset();
            OperationCode.resetDataMemoryAddress();

            for(int i = startLine + 1; i < sourceCode.Length; i++)
            {
                // オペコードとオペランドを初期化
                operationCode = "";
                operand = "";

                // 1行分取得
                string line = sourceCode[i];
                string[] term = line.Split(del, StringSplitOptions.RemoveEmptyEntries);
                
                if (line.IndexOf(term[0]) == 0)
                {
                    // ラベル付き(term[0]はラベル)
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

                // 機械語へ変換
                OperationCode.compileOperationCode(operationCode, operand);
            }

        }
    }
}
