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

        public Building(int x, int y, int largeurH, int largeurV, int taille, Color color)
        {
            this.x = x;
            this.y = y;
            this.largeurH = largeurH;
            this.largeurV = largeurV;
            this.taille = taille;
            this.color = color;
        }
    }
}
