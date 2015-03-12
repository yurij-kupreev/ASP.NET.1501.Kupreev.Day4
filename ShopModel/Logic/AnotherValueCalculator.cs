using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class AnotherValueCalculator:ICalculator
    {
        public decimal ValueProducts(IEnumerable<SomeProduct> products, int discount)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price / 2;
            }
            return sumOfProduct * (decimal)(1 - (double)discount / 100);
        }
    }
}
