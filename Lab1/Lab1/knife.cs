using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class knife
    {
        public void Break(egg e)
        { 
            if(e.Have_skin)
            {            
                e.Have_skin = false;
            }
        }
    }
}
