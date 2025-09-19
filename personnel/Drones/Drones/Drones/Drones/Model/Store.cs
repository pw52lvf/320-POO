using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        List<string> openingH = new List<string>();

        public Store(List<string> openingH, int x, int y, int largeurH, int largeurV, int taille) : base(x, y, largeurH, largeurV, taille)
        {
            this.openingH = openingH;
        }
    }
}
