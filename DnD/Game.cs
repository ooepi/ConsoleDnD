using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Game
    {
        MusicBox mb = null;
        Character c = null;

        public void Start()
        {
            mb = new MusicBox();
            c = new Character();
        }
    }
}
