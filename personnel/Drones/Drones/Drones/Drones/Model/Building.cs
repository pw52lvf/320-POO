using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        int x = Helpers.GlobalHelpers.alea.Next(1, 1200);
        int y = Helpers.GlobalHelpers.alea.Next(1, 600);
        int largeurH = Helpers.GlobalHelpers.alea.Next(20, 50);
        int largeurV = Helpers.GlobalHelpers.alea.Next(20, 50);
        int taille;
        Color color;
        bool unefois = true;

        public Building(int taille)
        {
            //this.x = x;
            //this.y = y;
            //this.largeurH = largeurH;
            //this.largeurV = largeurV;
            this.taille = taille;
        }

        public void Update(int interval)
        {
            if (unefois)
            {
                unefois = false;
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(largeurH);
                Console.WriteLine(largeurV);
                Console.WriteLine(taille);
            }
        }
    }
}
