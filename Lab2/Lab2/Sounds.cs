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

        public Sounds(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 8)
            {
                MaxSound = Convert.ToInt32(strs[0]);
                MaxCountMusic = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                countStrun = Convert.ToInt32(strs[3]);
                ColorBoby = Color.FromName(strs[4]);
                powerUsilit = Convert.ToInt32(strs[5]);
                notka = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);
            }


        }

        protected override void drawSound(Graphics g)
        {           
            Brush br = new SolidBrush(dopColor);
            g.FillRectangle(br,startPosX, startPosY +60, 5, 75);
            base.drawSound(g);
        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return MaxSound + ";" + MaxCountMusic + ";" + Weight + ";" + countStrun + ";"
                + ColorBoby.Name + ";" + powerUsilit + ";" + notka + ";" + dopColor.Name;
        }
    }
}
