using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class Address
    {
        private static byte address = 0x00;
        
        public static byte get()
        {
            return address;
        }

        public static void increment()
        {
            address = (address == 0x7F) ? (byte)0 : (byte)++address;
        }

        public static void decrement()
        {
            address = (address == 0x00) ? (byte)0x7F : (byte)--address;
        }

        public static void set(byte addr)
        {
            if (0x7F <= addr && addr >= 0x0)
                address = addr;
        }
    }
}
