using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Guid : Interface
    {
        protected float startPosX;

        protected float startPosY;

        protected int countMusic;

        public virtual void setPos(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public virtual int MaxCountMusic { protected set; get; }

        public virtual int MaxSound { protected set; get; }

        public virtual int countStrun { protected set; get; }

        public Color ColorBoby { protected set; get; }

        public virtual double Weight { protected set; get; }

        public abstract void makesound(Graphics g);

        public abstract void draw(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void loadMusic(int count)
        {
            if(countMusic + count < MaxCountMusic)
            {
                countMusic += count;
            }
        }

        public int getMusic()
        {
            int count = countMusic;
            countMusic = 0;
            return count;
        }

        public virtual void setMainColor(Color color)
        {
            ColorBoby = color;
        }
    }
}
