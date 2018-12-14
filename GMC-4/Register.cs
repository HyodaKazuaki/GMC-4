using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class Register
    {
        private static Word flag = new Word();
        private static Word[] aRegister;
        private static Word[] bRegister;
        private static Word[] yRegister;
        private static Word[] zRegister;

        public static char Flag
        {
            get { return flag.get(); }
            set { flag.set(value); }
        }

        public static char A
        {
            get { return aRegister[0].get(); }
            set { aRegister[0].set(value); }
        }

        public static char A0
        {
            get { return aRegister[1].get(); }
            set { aRegister[1].set(value); }
        }

        public static char B
        {
            get { return bRegister[0].get(); }
            set { bRegister[0].set(value); }
        }

        public static char B0
        {
            get { return bRegister[1].get(); }
            set { bRegister[1].set(value); }
        }

        public static char Y
        {
            get { return yRegister[0].get(); }
            set { yRegister[0].set(value); }
        }

        public static char Y0
        {
            get { return yRegister[1].get(); }
            set { yRegister[1].set(value); }
        }

        public static char Z
        {
            get { return zRegister[0].get(); }
            set { zRegister[0].set(value); }
        }

        public static char Z0
        {
            get { return zRegister[1].get(); }
            set { zRegister[1].set(value); }
        }

        public static void reset()
        {
            aRegister = Enumerable.Repeat(new Word(), 2).ToArray(); //aRegister(reg => reg = new Word()).ToArray();
            bRegister = Enumerable.Repeat(new Word(), 2).ToArray(); //bRegister.Select(reg => reg = new Word()).ToArray();
            yRegister = Enumerable.Repeat(new Word(), 2).ToArray(); //yRegister.Select(reg => reg = new Word()).ToArray();
            zRegister = Enumerable.Repeat(new Word(), 2).ToArray(); //zRegister.Select(reg => reg = new Word()).ToArray();
        }
    }
}
