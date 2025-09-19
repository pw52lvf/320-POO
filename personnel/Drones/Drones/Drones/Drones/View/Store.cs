using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private Brush buildBrush = new SolidBrush(Color.Orange);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(buildBrush, x, y, largeurH, largeurV);
        }
    }
}
