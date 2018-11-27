using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Label
    {
        private static string _name;
        private static string _address;

        public Label(string name, int address)
        {
            _name = name;
            _address = address.ToString("X2");
        }

        public static string Name()
        {
            return _name;
        }

        public static string Address()
        {
            return _address;
        }
    }
}
