using System;
using System.Collections.Generic;
using System.Linq;

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
            // 小文字を大文字に変換
            sourceCode = sourceCode.Select(code => code.ToUpperInvariant()).ToArray();
        }

        /// <summary>
        /// ソースコードをコンパイルします。
        /// </summary>
        public void Compile()
        {
            // コンパイル前の初期化処理
            Memory.reset();
            Memory.resetLabel();
            Address.reset();
            OperationCode.resetDataMemoryAddress();

            // スタートラインを探し、ラベルを処理した上で機械語に変換する
            try
            {
                getStartLine();
                addLabel();
                compileOperation();
            }
            catch (StartLineNotFoundException e)
            {
                Error error = new Error("E11", "スタートラインが見つかりません。");
                return;
            }
            catch (EndLineNotFoundException e)
            {
                Error error = new Error("E12", "エンドラインが見つかりません。");
                return;
            }
        }

        private void convertUppercaseLetter()
        {
            throw new NotImplementedException();
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
            bool notFoundStartLine = true;
            foreach (var line in sourceCode.Select((value, index) => new { value, index }))
            {
                string[] term = line.value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                // STARTから始まる行をスタートラインとする
                if (term[0] == "START" && line.value.IndexOf(term[0]) != 0)
                {
                    startLine = line.index;
                    notFoundStartLine = false;
                    break;
                }
            }
            // スタートラインがない
            if (notFoundStartLine) throw new StartLineNotFoundException();
        }

        /// <summary>
        /// ラベルを追加します。
        /// </summary>
        private void addLabel()
        {
            string operationCode = "";
            bool notFoundEndLine = true;
            for (int i = startLine + 1; i < sourceCode.Length; i++)
            {
                try
                {
                    var value = sourceCode[i];
                    string[] term = value.Split(del, StringSplitOptions.RemoveEmptyEntries);

                    if (value.IndexOf(term[0]) == 0)
                    {
                        // ラベル名重複チェック
                        if (Memory.labelList.Count(x => x.Name() == term[0]) != 0)
                            throw new LabelDuplicationException();
                        // ラベル追加
                        Memory.labelList.Add(new Label(term[0], labelAddress));
                        // オペコードは第二引数部
                        operationCode = term[1];
                    }
                    else if (term[0] == "END" && value.IndexOf(term[0]) != 0)
                    {
                        // 終了
                        notFoundEndLine = false;
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
                catch (KeyNotFoundException e)
                {
                    Error error = new Error("E01", "命令 " + operationCode + " は存在しません。", i + 1);
                    return;
                }
                catch (LabelDuplicationException e)
                {
                    Error error = new Error("E22", "命令 " + operationCode + " のラベルはすでに使用されています。", i + 1);
                    return;
                }
            }

            if (notFoundEndLine) throw new EndLineNotFoundException();
        }

        /// <summary>
        /// オペレーションコードからコンパイルを行いメモリに書き込みます。
        /// </summary>
        private void compileOperation()
        {
            string operationCode = "";
            string operand = "";

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
                try
                {
                    OperationCode.compileOperationCode(operationCode, operand);
                }
                catch (ArgumentLackException e)
                {
                    Error error = new Error("E02", "命令 " + operationCode + " のオペランドがありません。", i + 1);
                    return;
                }
                catch (ArgumentExcessException e)
                {
                    Error error = new Error("E03", "命令 " + operationCode + " のオペランドが過剰です。", i + 1);
                    return;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Error error = new Error("E04", "命令 " + operationCode + " のオペランドが不正です。", i + 1);
                    return;
                }
                catch (InvalidOperationException e)
                {
                    Error error = new Error("E21", "命令 " + operationCode + " の指定するラベルは存在しません。", i + 1);
                    return;
                }
                catch (KeyNotFoundException e)
                {
                    Error error = new Error("E01", "命令 " + operationCode + " " + operand + " は存在しません", i + 1);
                    return;
                }
            }

        }
    }
}
