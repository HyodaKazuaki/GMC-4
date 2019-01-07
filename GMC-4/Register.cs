using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Register
    {
        private static Word flag = new Word();
        private static int aRegister = Program.HexToInt("6F");
        private static int aDRegister = Program.HexToInt("69");
        private static int bRegister = Program.HexToInt("6C");
        private static int bDRegister = Program.HexToInt("67");
        private static int yRegister = Program.HexToInt("6E");
        private static int yDRegister = Program.HexToInt("68");
        private static int zRegister = Program.HexToInt("6D");
        private static int zDRegister = Program.HexToInt("66");


        public static char Flag
        {
            get { return flag.get(); }
            set { flag.set(value); }
        }

        public static char A
        {
            get { return Memory.getWord(aRegister); }
            set { Memory.set(value, aRegister); }
        }

        public static char A0
        {
            get { return Memory.getWord(aDRegister); }
            set { Memory.set(value, aDRegister); }
        }

        public static char B
        {
            get { return Memory.getWord(bRegister); }
            set { Memory.set(value, bRegister); }
        }

        public static char B0
        {
            get { return Memory.getWord(bDRegister); }
            set { Memory.set(value, bDRegister); }
        }

        public static char Y
        {
            get { return Memory.getWord(yRegister); }
            set { Memory.set(value, yRegister); }

        }

        public static char Y0
        {
            get { return Memory.getWord(yDRegister); }
            set { Memory.set(value, yDRegister); }

        }

        public static char Z
        {
            get { return Memory.getWord(zRegister); }
            set { Memory.set(value, zRegister); }

        }

        public static char Z0
        {
            get { return Memory.getWord(zDRegister); }
            set { Memory.set(value, zDRegister); }

        }

        public static void reset()
        {
            flag = new Word();
            Memory.set('F', aRegister);
            Memory.set('F', aDRegister);
            Memory.set('F', bRegister);
            Memory.set('F', bDRegister);
            Memory.set('F', yRegister);
            Memory.set('F', yDRegister);
            Memory.set('F', zRegister);
            Memory.set('F', zDRegister);
        }
    }
}
