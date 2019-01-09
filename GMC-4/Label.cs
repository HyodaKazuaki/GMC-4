namespace GMC_4
{
    /// <summary>
    /// ラベル名とそのアドレス番地を16進数文字列で記憶するクラス
    /// </summary>
    class Label
    {
        private string _name;
        private string _address;

        /// <summary>
        /// ラベル名とアドレス番地を記憶します。
        /// </summary>
        /// <param name="name">ラベル名</param>
        /// <param name="address">16進数のアドレス番地</param>
        public Label(string name, int address)
        {
            _name = name;
            _address = address.ToString("X2");
        }

        /// <summary>
        /// ラベルの名前を返します。
        /// </summary>
        /// <returns>ラベル名</returns>
        public string Name()
        {
            return _name;
        }

        /// <summary>
        /// ラベルのアドレス番地を返します。
        /// </summary>
        /// <returns>16進数のアドレス番地</returns>
        public string Address()
        {
            return _address;
        }
    }
}
