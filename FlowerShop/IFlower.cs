using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IFlower
    {
        int Price { get; }
        void DefinePrice();
    }
}
