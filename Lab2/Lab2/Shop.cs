using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Shop
    {
        //ClassShop<Interface> shoping;
        List<ClassShop<Interface>> shoping;
        int countPlaces =6;
        int placesSizeWidth = 210;
        int placesSizeHight = 220;
        int currentLevel;

        public int getCurrentLevel
        {
            get { return currentLevel; }
        }

        public Shop(int countStages)
        {
            shoping = new List<ClassShop<Interface>>(countStages);
            for (int i = 0;i< countStages; i++)
            {
                shoping.Add(new ClassShop<Interface>(countPlaces, null));
            } 
            //shoping = new ClassShop<Interface>(countPlaces, null);
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < shoping.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if(currentLevel > 0)
            {
                currentLevel--;
            }
        }
        public int PutGitInShoping(Interface git)
        {
            return shoping[currentLevel] + git;
        }

        public Interface GetGitInShoping(int ticket)
        {
            return shoping[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarket(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var git = shoping[currentLevel][i];
                if (git != null)
                {
                    git.setPos(50 + i / 2 * placesSizeWidth, i % 2 * placesSizeHight + 15);
                    git.draw(g);
                }
            }
        }

        public void DrawMarket(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), 3 * placesSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, 3 * placesSizeWidth, 480);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; ++j)
                {
                    g.DrawLine(pen, i * placesSizeWidth, j * placesSizeHight, i * placesSizeWidth + 110, j * placesSizeHight);
                    if (j < 2)
                    {
                        g.DrawString((i * 2 + j +1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placesSizeWidth + 30, j * placesSizeHight + 20);
                    }
                }
                g.DrawLine(pen, i * placesSizeWidth, 0, i * placesSizeWidth, 400);
            }
        }
    }
}
