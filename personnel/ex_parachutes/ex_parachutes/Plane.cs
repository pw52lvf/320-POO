using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_parachutes
{
    public class Plane
    {
        public int x = 0;
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public Plane()
        {
            
        }

        public void update()
        {
            x++;
            x %= Config.SCREEN_WIDTH;
        }

        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.WriteLine(view[i]);
            }
        }
    }
}
