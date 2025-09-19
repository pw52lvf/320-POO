using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private Brush buildBrush = new SolidBrush(Color.Gray);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildBrush, x, y, largeurH, largeurV);
        }
    }
}
