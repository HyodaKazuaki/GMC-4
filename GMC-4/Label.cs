using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Label
    {
        private string _name;
        private string _address;

        public Label(string name, int address)
        {
            _name = name;
            _address = address.ToString("X2");
        }

        public string Name()
        {
            return _name;
        }

        public string Address()
        {
            return _address;
        }
    }
}
