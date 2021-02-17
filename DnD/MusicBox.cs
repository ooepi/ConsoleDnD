using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    public static class MusicBox
    {

        //notes
        private static int C1 = 265;
        private static int D = 297;
        private static int Eb = 315;
        private static int E = 334;
        private static int F = 354;
        private static int Gb = 375;
        private static int G = 397;
        private static int A = 446;
        private static int H = 500;
        private static int C2 = 530;


        //lenghts
        private static int longa = 4000;
        private static int ddble = 3000;
        private static int dble = 2000;
        private static int full = 1000;
        private static int half = 500;
        private static int quarter = 250;
        private static int eighth = 125;
        private static int sixteenth = 62;
        private static int thirty2nd = 31;

        private static void Note(int pitch, int length)
        {
            Console.Beep(pitch, length);
        }


        public static void VictorySong()
        {
            Note(G, sixteenth);
            Note(G, sixteenth);
            Note(G, thirty2nd);
            Note(H, half);
            Note(G, sixteenth);
            Note(H, full);

        }

        public static void DefeatSong()
        {
            Note(F, quarter);
            Note(E, quarter);
            Note(Eb, quarter);
            Note(D, quarter);
            Note(C1, full);

        }

        public static void BattleSong()
        {
            Note(C1, eighth);
            Note(D, eighth);
            Note(Eb, eighth);
            Note(E, eighth);
            Note(F, eighth);
            Note(E, eighth);
            Note(F, eighth);
            Note(E, eighth);
        }

        public static void SwingSound()
        {
            Note(C2, eighth);
        }
    }
}
