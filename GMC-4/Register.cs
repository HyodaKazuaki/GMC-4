﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Register
    {
        private char _value = '0';

        public char get()
        {
            return _value;
        }

        public void set(char value)
        {
            if (Program.IsHex(value))
                _value = value;
        }
    }
}
