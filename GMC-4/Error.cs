using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMC_4
{
    class Error
    {
        private string code;
        private string message;
        private int? line;

        /// <summary>
        /// エラーを表示します。
        /// </summary>
        /// <param name="errorCode">エラーコード</param>
        /// <param name="errorMessage">エラーメッセージ</param>
        /// <param name="errorLine">エラーの発生した行</param>
        public Error(string errorCode, string errorMessage, int? errorLine = null)
        {
            code = errorCode;
            message = errorMessage;
            line = errorLine;

            showErrorDialog();
        }

        /// <summary>
        /// エラーを表示します。
        /// </summary>
        private void showErrorDialog()
        {
            if(line is null)
                MessageBox.Show(code + " " + message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(code + " " + message + "行数: " + line, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class ArgumentLackException : ArgumentException
    {
        public ArgumentLackException(string message = "") : base(message)
        {
        }
    }

    public class ArgumentExcessException : ArgumentException
    {
        public ArgumentExcessException(string message = "") : base(message)
        {
        }
    }

    public class StartLineNotFoundException : Exception
    {
        public StartLineNotFoundException(string message = "") : base(message)
        {
        }
    }

    public class EndLineNotFoundException : Exception
    {
        public EndLineNotFoundException(string message = "") : base(message)
        {
        }
    }

    public class LabelDuplicationException : Exception
    {
        public LabelDuplicationException(string message = "") : base(message)
        {
        }
    }
}
