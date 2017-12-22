using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ShopAlreadyHave : Exception
    {
        public ShopAlreadyHave() : base("В магазине уже существует такой товар") { }
    }
}
