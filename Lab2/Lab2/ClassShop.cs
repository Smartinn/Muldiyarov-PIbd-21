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
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public static int operator +(ClassShop<T> p, T git)
        {
            if(p.places.Count == p.maxCount)
            {
                throw new ShopOverFlow();
            }
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, git);
                    return i;
                }
            }
            p.places.Add(p.places.Count, git);
            return p.places.Count - 1;
        }

        public static T operator -(ClassShop<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T git = p.places[index];
                p.places.Remove(index);
                return git;
            }
            throw new ShopIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public ClassShop(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }
        public T this [int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        
        }
    }

}
