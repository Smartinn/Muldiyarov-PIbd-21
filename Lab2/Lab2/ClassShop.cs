using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ClassShop<T> where T : Interface
    {
        private T[] places;
        private T defaultValue;

        public static int operator +(ClassShop<T> p, T git)
        {
            for(int i = 0; i < p.places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places[i] = git;
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(ClassShop<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T git = p.places[index];
                p.places[index] = p.defaultValue;
                return git;
            }
            return p.defaultValue;
        }

        private bool CheckFreePlace(int index)
        {
            if(index <0 || index > places.Length)
            {
                return false;
            }
            if (places[index] == null)
            {
                return true;
            }
            if (places[index].Equals(defaultValue))
            {
                return true;
            }
            return false;
        }

        public ClassShop(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new T[sizes];
            for(int i = 0; i < places.Length; i++)
            {
                places[i] = defaultValue;
            }
        }

        public T gerObject(int ind)
        {
            if(ind >-1 && ind < places.Length)
            {
                return places[ind];
            }
            return defaultValue;
        }

        public void Draw(Graphics g, int width, int height)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, width, height);
            int gitCount = 0;
            for (int i = 0, chet = 0; i < width; chet++)
            {
                for (int j = 0; (j + 1) * 220 < height; ++j)
                {
                    if (gitCount < places.Length)
                    {
                        if (places[gitCount] != null)
                        {
                            if (places[gitCount] is Interface)
                            {
                                (places[gitCount] as Interface).setPos(i + 40, j * 220 + 58);
                                (places[gitCount] as Interface).draw(g);
                            }
                        }
                        gitCount++;
                    }
                    g.DrawLine(pen, i, j * 220 + 30, i + 130, j * 220 + 30);
                }
                if (chet % 2 == 0)
                {
                    i += 180;
                }
                else
                {
                    g.DrawLine(pen, i + 140, 5, i + 140, height - 5);
                    i += 145;
                }
            }
        }
    }

}
