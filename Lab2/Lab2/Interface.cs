using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface Interface
    {
        void makesound(Graphics g);

        void draw(Graphics g);

        void setPos(int x, int y);

        void loadMusic(int count);

        int getMusic();

        void setMainColor(Color color);
    }
}
