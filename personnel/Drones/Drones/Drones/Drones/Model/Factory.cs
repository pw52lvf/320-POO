using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private int power;

        public Factory(int power, int x, int y, int largeurH, int largeurV, int taille) : base(x, y, largeurH, largeurV, taille)
        {
            this.power = power;
        }
    }
}
