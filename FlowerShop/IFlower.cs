using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    interface IFlower
    {
        int Price { get; }
        void DefinePrice();
    }
}
