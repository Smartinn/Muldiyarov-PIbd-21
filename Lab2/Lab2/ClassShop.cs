using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ClassShop<T> : IEnumerable<T>, IComparable<ClassShop<T>>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public static int operator +(ClassShop<T> p, T git)
        {
            var isGitara = git is Sounds;
            if (p.places.Count == p.maxCount)
            {
                throw new ShopOverFlow();
            }
            int index = p.places.Count;
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if(git.GetType() == p.places[i].GetType())
                {
                    if (isGitara)
                    {
                        if((git as Sounds).Equals(p.places[i]))
                        {
                            throw new ShopAlreadyHave();
                        }
                    }
                    else if((git as Gitara).Equals(p.places[i]))
                    {
                        throw new ShopAlreadyHave();
                    }
                }
            }
            if(index!= p.places.Count)
            {
                p.places.Add(index, git);
                return index;
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

        

        public IEnumerator<T> GetEnumerator()
        {
            return places.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassShop<T> other)
        {
            if(this.Count() > other.Count())
            {
                return -1;
            }else if(this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i  = 0; i< this.places.Count; ++i)
                {
                    if(this.places[thisKeys[i]] is Gitara &&
                        other.places[thisKeys[i]] is Sounds)
                    {
                        return 1;
                    }
                    if(this.places[thisKeys[i]] is Sounds &&
                        other.places[thisKeys[i]] is Gitara)
                    {
                        return -1;
                    }
                    if(this.places[thisKeys[i]] is Gitara &&
                        other.places[thisKeys[i]] is Gitara)
                    {
                        return (this.places[thisKeys[i]] is Gitara).CompareTo(other.places[thisKeys[i]] is Gitara);
                    }
                    if (this.places[thisKeys[i]] is Sounds &&
                        other.places[thisKeys[i]] is Sounds)
                    {
                        return (this.places[thisKeys[i]] is Sounds).CompareTo(other.places[thisKeys[i]] is Sounds);
                    }
                }
            }
            return 0;
        }
    }

}
