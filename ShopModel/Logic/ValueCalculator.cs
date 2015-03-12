using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public class ValueCalculator: ICalculator
    {
        public decimal ValueProducts(IEnumerable<SomeProduct> products, int discount)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct * (decimal)(1 - (double)discount / 100);
        }
    }
}
