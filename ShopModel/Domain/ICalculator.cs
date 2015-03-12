﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public interface ICalculator
    {
        decimal ValueProducts(IEnumerable<SomeProduct> products, int discount);
    }
}
