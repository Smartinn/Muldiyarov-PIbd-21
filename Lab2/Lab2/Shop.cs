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
        ClassShop<Interface> shoping;

        int countPlaces = 20;
        int placesSizeWidth = 210;
        int placesSizeHight = 80;

        public void Shoping()
        {
            shoping = new ClassShop<Interface>(countPlaces, null);
        }

        public int PutGitInShoping(Interface git)
        {
            return shoping + git;
        }

        public Interface GetGitInShoping(int ticket)
        {
            return shoping - ticket;
        }

        
    }
}
