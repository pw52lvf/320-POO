using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_parachutes
{
    public class Para
    {
        string nom;
        int x;
        int y;
        int realheight = Config.SCREEN_HEIGHT - 17;
        bool withPara = false;

        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };

        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        public Para(string nom, int x)
        {
            this.nom = nom;
            this.x = x;
        }

        public void update()
        {
            if (y < realheight)
            {
                if (y < realheight / 2)
                {
                    withPara = true;
                }
                y++;
            }
        }

        public void draw()
        {
            for (int i = 0; i < withoutParachute.Length; i++)
            {
                Console.SetCursorPosition(x, i + y);
                Console.WriteLine(withoutParachute[i]);
            }
        }
    }
}
