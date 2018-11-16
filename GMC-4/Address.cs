using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    static class Address
    {
        private static byte address = 0x00;
        
        public static byte getAddress()
        {
            return address;
        }

        public static void incrementAddress()
        {
            address = (address == 0x7F) ? (byte)0 : (byte)++address;
        }

        public static void decrementAddress()
        {
            address = (address == 0x00) ? (byte)0x7F : (byte)--address;
        }

        public static void setAddress(byte addr)
        {
            if (0x7F <= addr && addr >= 0x0)
                address = addr;
        }
    }
}
