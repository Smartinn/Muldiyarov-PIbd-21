using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class stove
    {
        private skovoroda skovorods;

        public bool State { set; get; }

        public skovoroda Skov { set { skovorods = value; } get { return skovorods; } }

        public void Cook()
        {
            if (State)
            {
                while (skovorods.IsReady() == false)
                {
                    skovorods.GetHeat();
                }
            }
        }


    }
}
