using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        protected int x;
        protected int y;
        protected int largeurH;
        protected int largeurV;
        protected int taille;

        public Building(int x, int y, int largeurH, int largeurV, int taille)
        {
            this.x = x;
            this.y = y;
            this.largeurH = largeurH;
            this.largeurV = largeurV;
            this.taille = taille;
        }
    }
}
