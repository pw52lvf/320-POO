using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drones.Helpers;

namespace Drones
{
    public partial class Building
    {
        private Brush buildBrush = new SolidBrush(Color.Brown);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildBrush, x, y, largeur, taille);
        }
    }
}
