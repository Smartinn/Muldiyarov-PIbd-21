using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Shop
    {
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using( FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + shoping.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in shoping)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for(int i = 0; i < countPlaces; i++)
                        {
                            var git = level[i];
                            if(git != null)
                            {
                                if(git.GetType().Name == "Gitara")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Gitara:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if(git.GetType().Name == "Sounds")
                                {
                                    info = new UTF8Encoding(true).GetBytes("EGitara:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(git.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    } 
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels")){
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if(shoping != null)
                    {
                        shoping.Clear();
                    }
                    shoping = new List<ClassShop<Interface>>(count);
                }
                else
                {
                    Console.Write("МДЯЯ");
                    return false;
                }
                int counter = -1;
                for(int i = 1; i < strs.Length; ++i)
                {
                    if(strs[i] == "Level")
                    {
                        counter++;
                        shoping.Add(new ClassShop<Interface>(countPlaces, null));
                    }
                    else if(strs[i].Split(':')[0] == "Gitara")
                    {
                        Interface git = new Gitara(strs[i].Split(':')[1]);
                        int number = shoping[counter] + git;
                        if(number == -1)
                        {
                            return false;
                        }
                    }else if (strs[i].Split(':')[0] == "EGitara")
                    {
                        Interface git = new Sounds(strs[i].Split(':')[1]);
                        int number = shoping[counter] + git;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
