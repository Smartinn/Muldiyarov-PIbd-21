using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Sounds : Gitara
    {
        private Color dopColor;
        private int powerUsilit;
        private bool notka;

        public Sounds(int maxSound, int maxCountMusic, double weight, int countstrun, int powerUsilit, Color color, Color dopColor) :
            base(maxSound, maxCountMusic, weight, countstrun, color)
        {
            this.powerUsilit = powerUsilit;
            this.dopColor = dopColor;
        }

        protected override void drawSound(Graphics g)
        {           
            Brush br = new SolidBrush(dopColor);
            g.FillRectangle(br,startPosX, startPosY +60, 5, 75);
            base.drawSound(g);
        }
    }
}
