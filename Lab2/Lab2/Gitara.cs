using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Gitara : Guid
    {
        public override int MaxSound
        {
            get
            {
                return base.MaxSound;
            }

            protected set
            {
                if(value > 0 && value < 100){
                    base.MaxSound = value;
                }
                else
                {
                    base.MaxSound = 50;
                }
            }
        }

        public override int MaxCountMusic
        {
            get
            {
                return base.MaxCountMusic;
            }

            protected set
            {
                if( value > 0 && value < 2)
                {
                    base.MaxCountMusic = value;
                }
                else
                {
                    base.MaxCountMusic = 1;
                }
            }
        }

        public override int countStrun
        {
            get
            {
                return base.countStrun;
            }

            protected set
            {
                if (value > 4 && value < 8)
                {
                    base.countStrun = value;
                }
                else
                {
                    base.countStrun = 6;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 1 && value < 15)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 3;
                }
            }
        }

        public Gitara(int maxSound, int maxCountMusic, double weight, int countstrun,  Color color)
        {
            this.MaxSound = maxSound;
            this.countStrun = countstrun;
            this.MaxCountMusic = MaxCountMusic;
            this.ColorBoby = color;
            this.Weight = weight;
            Random rand = new Random();
            startPosX = 40;
            startPosY = 60;
        }

        public override void setPos(int x, int y)
        {
            startPosX = x;
            startPosY = y+50;
        }

        public override void makesound(Graphics g)
        {
            draw(g);
            drawSounds(g);
        }

        public override void draw(Graphics g)
        {
            drawSound(g);
        }

        protected virtual void drawSound(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);
            Rectangle rect = new Rectangle((int)startPosX,(int) startPosY, 45, 35);
            g.DrawArc(pen, rect, 145, 255);
            rect = new Rectangle((int)startPosX - 5,(int) startPosY + 25, 55, 55);
            g.DrawArc(pen, rect, 305, 290);
            SolidBrush brush = new SolidBrush(ColorBoby);
            rect = new Rectangle((int)startPosX, (int)startPosY, 45, 35);
            g.FillPie(brush, rect, 0, 360);
            rect = new Rectangle((int)startPosX - 5, (int)startPosY + 25, 55, 55);
            g.FillPie(brush, rect, 0, 360);
            brush = new SolidBrush(Color.Black);
            rect = new Rectangle((int)startPosX +13, (int)startPosY + 41, 20, 20);
            g.FillPie(brush, rect, 0, 360);
            brush = new SolidBrush(Color.Brown);
            g.FillRectangle(brush, new Rectangle((int)startPosX + 18, (int)startPosY - 50, 10, 85));
            g.FillRectangle(brush, new Rectangle((int)startPosX + 15, (int)startPosY + 63, 16, 4));
            pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, new Rectangle((int)startPosX + 18, (int)startPosY - 50, 10, 85));
            g.DrawRectangle(pen, new Rectangle((int)startPosX + 15, (int)startPosY + 63, 16, 4));
            brush = new SolidBrush(Color.Brown);
            g.FillRectangle(brush, new Rectangle((int)startPosX + 16, (int)startPosY - 55, 14, 20));
            pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, new Rectangle((int)startPosX + 16, (int)startPosY - 55, 14, 20));
        }


        protected virtual void drawSounds(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);
            Rectangle rect;
            Console.Write(Weight * countStrun * MaxSound * MaxCountMusic / 16);
            for (int i = 0; i < Weight * countStrun * MaxSound * MaxCountMusic / 8; i++)
            {
                rect = new Rectangle((int)startPosX + i * 2, (int)startPosY - 5 * i, 60 + 10 * i, 60 + 10 * i);
                g.DrawArc(pen, rect, 315, 90);
            }
        }
    }
}
