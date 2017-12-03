using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class skovoroda
    {
        private salt salt;

        private maslo maslo;

        private milk milk;

        private egg[] eggs;
        
        public bool ReadyToGo { get { return Check(); } }

        private int temperature = 0;

        public void Init(int countEggs)
        {
            eggs = new egg[countEggs];
        }

        public void AddMilk(milk w)
        {
            milk = w;
        }

        public void AddSalt (salt s)
        {
            salt = s;
        }

        public void AddMaslo (maslo m)
        {
            maslo = m;
        }
    
        public void AddEggs(egg e)
        {
            for (int i =0; i< eggs.Length; ++i)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = e;
                    return;
                }
            }
        }

        private bool Check()
        {
            if (eggs.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                if(eggs[i] == null)
                {
                    return false;
                }
            }

            return true;
        }

        public void GetHeat()
        {
            if (temperature < 250)
            {
                temperature++;
            }
            for(int i = 0; i < eggs.Length; ++i)
            {
                eggs[i].GetHeat();
            }
            if (!Check())
            {
                return;
            }
        }

        public bool IsReady()
        {
            if (temperature < 250) {
                return false;
            }
            for (int i = 0; i < eggs.Length; ++i)
                {
                    if(eggs[i].Has_ready < 10)
                        {
                            return false;
                        }
                }
            return true;
        }

        public egg[] GetEggs()
        {
            return eggs;
        }
    }
}
