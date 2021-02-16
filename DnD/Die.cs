using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    static class Die
    {
        private static Random random = new Random();

        public static int Roll1d6()
        {
            return random.Next(1, 7);
        }

        public static int[] Roll2d6()
        {
            return new int[] { random.Next(1, 7), random.Next(1, 7) };
        }

        public static int Roll1d20()
        {
            return random.Next(1, 21);
        }

    }
}
