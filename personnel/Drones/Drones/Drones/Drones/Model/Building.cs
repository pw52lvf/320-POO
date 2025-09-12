using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        int x;
        int y;
        int largeur;
        int taille;
        Color color;

        public Building(int x, int y, int largeur, int taille, Color color)
        {
            this.x = x;
            this.y = y;
            this.largeur = largeur;
            this.taille = taille;
            this.color = color;
        }
    }
}
