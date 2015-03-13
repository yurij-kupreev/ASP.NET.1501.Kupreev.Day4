using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private readonly ICalculator valueCalc;

        public IEnumerable<SomeProduct> Products { get; set; }

        public ShoppingCart(ICalculator value)
        {
            valueCalc = value;
        }

        public decimal CalculateProductTotal(int discount)
        {
            if (discount < 0 || discount > 100) throw new ArgumentException();
            return valueCalc.ValueProducts(Products, discount);
        }
        public decimal CalculateProductTotal()
        {
            return valueCalc.ValueProducts(Products, 0);
        }
    }
}
