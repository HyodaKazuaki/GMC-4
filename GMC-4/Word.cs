namespace GMC_4
{
    /// <summary>
    /// 1ワードを記憶するクラス
    /// </summary>
    class Word
    {
        private char _value = '0';

        /// <summary>
        /// 1ワードを記憶します。
        /// </summary>
        /// <param name="value">値</param>
        public Word(char value = '0') {
            _value = value;
        }

        /// <summary>
        /// 記憶したワードを返します。
        /// </summary>
        /// <returns>値</returns>
        public char get()
        {
            return _value;
        }

        /// <summary>
        /// 値を1ワード分セットします。
        /// </summary>
        /// <param name="value">値</param>
        public void set(char value)
        {
            if (Program.IsHex(value))
                _value = value;
        }
    }
}
