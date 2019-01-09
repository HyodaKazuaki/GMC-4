using System;

namespace GMC_4
{
    class Sound
    {
        public static void error()
        {
            Console.Beep(1200, 1000);
        }

        public static void end()
        {
            Console.Beep(170, 750);
        }

        public static void shortBeep()
        {
            Console.Beep(3000, 100);
        }

        public static void longBeep()
        {
            Console.Beep(3000, 1000);
        }
    }
}
